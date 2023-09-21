using TranSPEiApiModGes.Domain.Aggregates;
using Domain.Models;

namespace TranSPEiApiModGes.Application.Common.Interfaces.Persistence;

public interface IAdminstratorRepository
{
    Task<TransferAggregate> AddAccountCredit(int accountId,decimal amount);
}