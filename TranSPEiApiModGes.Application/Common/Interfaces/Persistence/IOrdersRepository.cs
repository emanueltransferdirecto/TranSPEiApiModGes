using TranSPEiApiModGes.Application.Customers.Commands.AddAccountCredit;
using TranSPEiApiModGes.Domain.Aggregates;
using Domain.Domains;

namespace TranSPEiApiModGes.Application.Common.Interfaces.Persistence;

public interface IOrdersRepository
{
    Task<OrderAggregate> Create(/* Modelo o parametros */);
}