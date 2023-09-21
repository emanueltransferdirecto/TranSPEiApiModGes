using System;
using Domain.Domains;

namespace TranSPEiApiModGes.Application.Authentication.Common;

public record AuthenticationResult(User user, string Token);


