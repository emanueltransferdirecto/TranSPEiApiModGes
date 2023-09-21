
using TranSPEiApiModGes.Api.Common.Mapping;
using TranSPEiApiModGes.Api.Service;
using MediatR;

namespace TranSPEiApiModGes.Api;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation (this IServiceCollection services)
    {
        services.AddControllers();
        services.AddMappings();
        services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        services.AddTransient<JwtService>();
        return services;
    }
}

