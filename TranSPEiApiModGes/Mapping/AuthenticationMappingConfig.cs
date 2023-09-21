using System;
using TranSPEiApiModGes.Application.Authentication.Common;
using TranSPEiApiModGes.Contracts.Authentication;
using Mapster;

namespace TranSPEiApiModGes.Api.Mapping;

public class AuthenticationMappingConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<AuthenticationResult, AuthenticationResponse>()
            .Map(dest => dest.Token, src => src.Token)
            .Map(dest => dest, src => src.user)
            .Map(dest => dest.userId, src => src.user.UserId);
            
    }
}


