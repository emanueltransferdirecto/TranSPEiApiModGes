using TranSPEiApiModGes.Application.Common.Errors;
using TranSPEiApiModGes.Application.Common.Interfaces.Persistence;
using TranSPEiApiModGes.Application.Customers.Response.Queries;
using MediatR;


namespace TranSPEiApiModGes.Application.Accounts.Queries.GetAccounts;

public class GetAccountsQueryHandler : IRequestHandler<GetAccountsQuery, GetAccountsResult>
{
    private readonly IAccountsRepository _AccountsRepository;

    public GetAccountsQueryHandler(IAccountsRepository accountsRepository)
    {
        _AccountsRepository = accountsRepository;
    }

    public async Task<GetAccountsResult> Handle(GetAccountsQuery query, CancellationToken cancellationToken)
    {
        if (query.UserId == Guid.Empty)
        {
            throw new InvalidUser();
        }
        var result = await _AccountsRepository.GetAccounts(query.UserId);

        return new GetAccountsResult(result);
        
    }

}
