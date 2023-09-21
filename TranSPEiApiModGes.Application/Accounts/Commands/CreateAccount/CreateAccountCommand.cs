using TranSPEiApiModGes.Application.Accounts.Response.Commands;
using TranSPEiApiModGes.Application.Customers.Response.Commands;
using MediatR;

namespace TranSPEiApiModGes.Application.Accounts.Commands;

public record CreateAccountCommand(
    Guid UserId,
    string Frequency,
    int AccountTypesId
    ) : IRequest<CreateAccountResult>;

