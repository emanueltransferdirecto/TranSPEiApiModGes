using System;
using Domain.Domains;

namespace TranSPEiApiModGes.Application.Common.Interfaces;

public interface IJwtTokenGenerator
{
    string GenerateToken(User user);
}

