using System;
namespace TranSPEiApiModGes.Infrastructure.Presistence;

public class ApplicationSettings
{
    public const string SectionName = "ConnectionStrings";

    public string MySQL { get; set; } = null!;
}

