﻿using TranSPEiApiModGes.Domain.Aggregates;

namespace TranSPEiApiModGes.Application.Common.Interfaces.Persistence;

public interface ITransactionsRepository
{
    Task<TransferAggregate> Transfer(Guid userId, int accountId, string operation, decimal amount, string account);
    Task<IEnumerable<AccountAggregate?>> GetTransactionsByAccId(Guid userId, int accountId);

}