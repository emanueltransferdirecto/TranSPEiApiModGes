using System;
using TranSPEiApiModGes.Domain.Aggregates;

namespace TranSPEiApiModGes.Application.Accounts.Response.Commands;

public record TransferResult(TransferAggregate Transfer);


