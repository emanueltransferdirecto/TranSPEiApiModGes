using System;
using TranSPEiApiModGes.Application.Customers.Response.Queries;
using MediatR;

namespace TranSPEiApiModGes.Application.Accounts.Queries.GetAccounts;

public record GetAccountsQuery(Guid UserId) : IRequest<GetAccountsResult>;
