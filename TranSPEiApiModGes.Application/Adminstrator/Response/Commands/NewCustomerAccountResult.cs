using System;
using TranSPEiApiModGes.Domain.Aggregates;

namespace TranSPEiApiModGes.Application.Adminstrator.Response.Commands;

public record NewCustomerAccountResult(NewCustomerAccountAggregate DispositionCustomerAccount);

