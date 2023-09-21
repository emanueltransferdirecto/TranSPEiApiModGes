using TranSPEiApiModGes.Application.Adminstrator;
using TranSPEiApiModGes.Application.Authentication.Common;
using TranSPEiApiModGes.Application.Customers.Response.Commands;
using TranSPEiApiModGes.Contracts.Authentication;
using Mapster;

namespace TranSPEiApiModGes.Api.Mapping;

public class AddAccountCreditMappingConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<AddAccountCreditResult, AddAccountCreditResponse>()
            .Map(dest => dest.TransactionId, src => src.Transfer.TransactionId)
            .Map(dest => dest.RetrieverAccount, src => src.Transfer.AccountId)
            .Map(dest => dest.Date, src => src.Transfer.Date)
            .Map(dest => dest.Operation, src => src.Transfer.Operation)
            .Map(dest => dest.Amount, src => src.Transfer.Amount)
            .Map(dest => dest.Balance, src => src.Transfer.Balance);
    }
}

