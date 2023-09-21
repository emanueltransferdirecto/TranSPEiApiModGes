using TranSPEiApiModGes.Application.Customers.Commands.AddAccountCredit;
using TranSPEiApiModGes.Domain.Aggregates;
using Domain.Domains;

namespace TranSPEiApiModGes.Application.Common.Interfaces.Persistence;

public interface ICustomerRepository
{
    Task<NewCustomerAccountAggregate> NewCustomerAccount(User user, NewCustomerAccountCommand command);
}