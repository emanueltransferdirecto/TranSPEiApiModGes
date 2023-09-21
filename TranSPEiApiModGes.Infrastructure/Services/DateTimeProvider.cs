using System;
using TranSPEiApiModGes.Application.Common.Interfaces.Services;

namespace TranSPEiApiModGes.Infrastructure.Services;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}

