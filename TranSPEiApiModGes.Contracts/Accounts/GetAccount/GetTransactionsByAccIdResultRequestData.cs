using System;
namespace TranSPEiApiModGes.Contracts.Accounts;

public record GetTransactionsByAccIdResultRequestData(
    Guid UserId,
    int AccountId);


