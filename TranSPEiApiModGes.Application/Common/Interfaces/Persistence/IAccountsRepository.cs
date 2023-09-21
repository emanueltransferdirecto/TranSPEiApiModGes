using System;
using TranSPEiApiModGes.Domain.Aggregates;
using Domain.Domains;
using Domain.Models;
using MediatR;

namespace TranSPEiApiModGes.Application.Common.Interfaces.Persistence;

public interface IAccountsRepository
{
    Task<Account?> CreateAccount(Guid userId,string frequency, int AccountTypesId, int? CustomerId);
    Task<IEnumerable<Account>>GetAccounts(Guid userId);
}

