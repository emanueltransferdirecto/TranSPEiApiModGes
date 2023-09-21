using TranSPEiApiModGes.Application.Accounts.Response.Commands;
using MediatR;

namespace TranSPEiApiModGes.Application.Transactions.Commands.Transfer;

public record TransferCommand(
    Guid UserId,
    int AccountId,
    int Operation,
    decimal Amount,
    string Account) : IRequest<TransferResult>;



