﻿using System;
using TranSPEiApiModGes.Application.Common.Errors;
using System.Data;
using TranSPEiApiModGes.Application.Common.Interfaces.Persistence;
using TranSPEiApiModGes.Domain.Aggregates;
using Dapper;
using static Dapper.SqlMapper;

namespace TranSPEiApiModGes.Infrastructure.Presistence;

public class TransactionsRepository : ITransactionsRepository
{
    private readonly DapperContext _context;

    public TransactionsRepository(DapperContext context)
    {
        _context = context;
    }

    public async Task<TransferAggregate> Transfer(Guid userId, int accountId, string operation, decimal amount, string account)
    {
        using (var db = _context.CreateConnection())
        {
            try
            {
                //Validate owner of account & that it exist.
                DynamicParameters dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@AccountId", accountId);
                dynamicParameters.Add("@UserId", userId);
                var validTransfer = await db.ExecuteScalarAsync<int>("IsValidTransfer", dynamicParameters, commandType: CommandType.StoredProcedure);
                if (validTransfer > 0)
                {
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@accountId", accountId);
                    parameters.Add("@operation", operation);
                    parameters.Add("@transferAmount", amount);
                    parameters.Add("@destinationAccountNumber", account);

                    var result = await db.QueryFirstOrDefaultAsync<TransferAggregate>("Transfer", parameters, commandType: CommandType.StoredProcedure);
                    if (result is null)
                    {
                        throw new InsufficientFunds();
                    }
                    return result;
                }
                else
                {
                    throw new InvalidTransfer();
                }
            }
            catch (InsufficientFunds)
            {
                throw new InsufficientFunds();
            }
            catch (Exception)
            {
                throw new InvalidTransfer();
            }
        }
    }
    public async Task<IEnumerable<AccountAggregate?>> GetTransactionsByAccId(Guid userId, int accountId)
    {
        using (var db = _context.CreateConnection())
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@AccountId", accountId);
            parameters.Add("@UserId", userId);
            var validAccOwner = await db.ExecuteScalarAsync<int>("IsValidTransfer", parameters, commandType: CommandType.StoredProcedure);

            if (validAccOwner >0)
            {
                return await db.QueryAsync<AccountAggregate>("GetTransactionsByAccId", parameters, commandType: CommandType.StoredProcedure);
            }
            return null;
        }
    }

}

