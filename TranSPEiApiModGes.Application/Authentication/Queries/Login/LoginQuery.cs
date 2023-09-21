using TranSPEiApiModGes.Application.Authentication.Common;
using MediatR;

namespace TranSPEiApiModGes.Application.Services.Queries.Login;

public record LoginQuery(
    string Email,
    string Password) : IRequest<AuthenticationResult>;

