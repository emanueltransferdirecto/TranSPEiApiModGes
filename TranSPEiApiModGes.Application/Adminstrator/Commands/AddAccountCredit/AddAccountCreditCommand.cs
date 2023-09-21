using TranSPEiApiModGes.Application.Customers.Response.Commands;
using MediatR;

namespace TranSPEiApiModGes.Application.Customers.Commands.AddAccountCredit;

public record AddAccountCreditCommand(
    Guid UserId,
    int AccountId,
    int Operation,
    decimal Amount,
    string Account
    ) : IRequest<AddAccountCreditResult>;