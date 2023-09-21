using TranSPEiApiModGes.Domain.Aggregates;

namespace TranSPEiApiModGes.Application.Customers.Response.Queries;

public record GetTransactionsByAccIdResult(IEnumerable<AccountAggregate> Account);


