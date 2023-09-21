using System;
namespace TranSPEiApiModGes.Contracts.Accounts;

public record CreateAccountRequestData(
    Guid UserId,
    string Frequency,
    int AccountTypesId);


