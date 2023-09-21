using System.Data;
using TranSPEiApiModGes.Application.Common.Errors;
using TranSPEiApiModGes.Application.Common.Interfaces.Persistence;
using TranSPEiApiModGes.Domain.Aggregates;
using Dapper;
using Domain.Models;

namespace TranSPEiApiModGes.Infrastructure.Presistence;

public class AccountsRepository : IAccountsRepository
{
    private readonly ApplicationContext _context;

    public AccountsRepository(ApplicationContext context)
    {
        _context = context;
    }


    public async Task<Account?> CreateAccount(Guid userId, string frequency, int AccountTypesId, int? CustomerId)
    {
        using (var db = _context.CreateConnection())
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@customerId", CustomerId);
                parameters.Add("@userId", userId);
                parameters.Add("@frequency", frequency);
                parameters.Add("@accountTypesId", AccountTypesId);
                var result= await db.QuerySingleAsync<Account>("CreateAccount", parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }

    public async Task<IEnumerable<Account>> GetAccounts(Guid userId)
    {
        using (var db = _context.CreateConnection())
        {
            return await db.QueryAsync<Account>("GetAccounts", new { userId }, commandType: CommandType.StoredProcedure);
        }
    }
}

