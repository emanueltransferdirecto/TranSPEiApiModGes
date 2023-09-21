using TranSPEiApiModGes.Application.Accounts;
using TranSPEiApiModGes.Application.Accounts.Response.Commands;
using TranSPEiApiModGes.Application.Customers;
using TranSPEiApiModGes.Application.Customers.Response.Commands;
using Mapster;

namespace TranSPEiApiModGes.Api.Mapping;

public class CreateAccountMappingConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<CreateAccountResult, CreateAccountResponse>()
            .Map(dest => dest.AccountId, src => src.Account.AccountId)
            .Map(dest => dest.Frequency, src => src.Account.Frequency)
            .Map(dest => dest.Created, src => src.Account.Created)
            .Map(dest => dest.Balance, src => src.Account.Balance)
            .Map(dest => dest.AccountTypesId, src => src.Account.AccountTypesId);
    }
}


