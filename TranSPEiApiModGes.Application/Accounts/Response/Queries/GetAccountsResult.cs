using Domain.Models;

namespace TranSPEiApiModGes.Application.Customers.Response.Queries;

public record GetAccountsResult(IEnumerable<Account> account);

