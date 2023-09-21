using TranSPEiApiModGes.Application.Accounts;
using TranSPEiApiModGes.Application.Customers.Response.Queries;
using Mapster;

namespace TranSPEiApiModGes.Api.Mapping;

public class GetAccountsMappingConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<GetAccountsResult, GetAccountsResponse>()
            .Map(dest => dest.Accounts, src => src.account);
    }
}
