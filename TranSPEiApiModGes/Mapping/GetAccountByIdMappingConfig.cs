using TranSPEiApiModGes.Application.Customers.Response.Queries;
using TranSPEiApiModGes.Contracts.Accounts;
using Mapster;

namespace TranSPEiApiModGes.Api.Mapping;

public class GetAccountByIdMappingConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<GetTransactionsByAccIdResult, GetTransactionsByAccIdResultResponse>()
            .Map(dest => dest.Transactions, src => src.Account);

    }
}
