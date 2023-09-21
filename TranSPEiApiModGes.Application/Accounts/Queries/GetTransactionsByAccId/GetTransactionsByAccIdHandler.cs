using TranSPEiApiModGes.Application.Accounts.Queries.GetAccountById;
using TranSPEiApiModGes.Application.Common.Errors;
using TranSPEiApiModGes.Application.Common.Interfaces.Persistence;
using TranSPEiApiModGes.Application.Customers.Response.Queries;
using MediatR;

namespace TranSPEiApiModGes.Application.Accounts.Queries.GetTransactionsByAccId;

public class GetAccountByIdHandler : IRequestHandler<GetTransactionsByAccIdQuery, GetTransactionsByAccIdResult>
{
    private readonly ITransactionsRepository _TransactionsRepository;

    public GetAccountByIdHandler(ITransactionsRepository transactionsRepository)
    {
        _TransactionsRepository = transactionsRepository;
    }

    public async Task<GetTransactionsByAccIdResult> Handle(GetTransactionsByAccIdQuery query, CancellationToken cancellationToken)
    {
        if (query.AccountId == 0)
        {
            throw new InvalidAccount();
        }
        var result = await _TransactionsRepository.GetTransactionsByAccId(query.UserId,query.AccountId);
        if (result is null)
        {
            throw new InvalidAccount();
        }
        return new GetTransactionsByAccIdResult(result);

    }

}

