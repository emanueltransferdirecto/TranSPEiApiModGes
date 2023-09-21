using System;
using TranSPEiApiModGes.Application.Customers.Response.Queries;
using MediatR;

namespace TranSPEiApiModGes.Application.Accounts.Queries.GetAccountById;

public record GetTransactionsByAccIdQuery(Guid UserId, int AccountId) : IRequest <GetTransactionsByAccIdResult>;


