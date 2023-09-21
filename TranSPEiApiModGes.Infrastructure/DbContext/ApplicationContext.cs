using System;
using System.Data;
using System.Data.SqlClient;
using TranSPEiApiModGes.Infrastructure.Presistence;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using MySqlConnector;

namespace TranSPEiApiModGes.Infrastructure;

public class ApplicationContext
{
    private readonly ApplicationSettings _applicationSettings;

    public ApplicationContext(IOptions<ApplicationSettings> Application)
    {
        _applicationSettings = Application.Value;
    }

    public IDbConnection CreateConnection()
        => new MySqlConnection(_applicationSettings.MySQL);

}



