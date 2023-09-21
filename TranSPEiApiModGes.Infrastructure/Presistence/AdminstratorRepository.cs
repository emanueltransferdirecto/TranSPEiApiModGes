﻿using System;
using TranSPEiApiModGes.Application.Common.Errors;
using System.Data;
using TranSPEiApiModGes.Application.Common.Interfaces.Persistence;
using TranSPEiApiModGes.Domain.Aggregates;
using Dapper;
using Domain.Models;

namespace TranSPEiApiModGes.Infrastructure.Presistence;

public class AdminstratorRepository : IAdminstratorRepository
{
    private readonly DapperContext _context;

    public AdminstratorRepository(DapperContext context)
    {
        _context = context;
    }

    public async Task<TransferAggregate> AddAccountCredit(int accountId,decimal amount)
    {
        using (var db = _context.CreateConnection())
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@accountId", accountId);
                parameters.Add("@creditDeposit", amount);

                var result = await db.QueryFirstOrDefaultAsync<TransferAggregate>("AddAccountCredit", parameters, commandType: CommandType.StoredProcedure);

                if (result is null)
                {
                    throw new InvalidAccount();
                }
                return result;
            }
            catch (Exception)
            {
                throw new InternalServerError();
            }
            throw new InternalServerError();
        }
    }
}

