using TranSPEiApiModGes.Application.Authentication.Common;
using MediatR;

namespace TranSPEiApiModGes.Application.Services.Commands.Register;

public record RegisterCommand(
    string Email,
    string Password,
    string Role): IRequest<AuthenticationResult>;

