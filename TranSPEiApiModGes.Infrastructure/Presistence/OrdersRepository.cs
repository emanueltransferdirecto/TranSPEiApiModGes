using System;
using Dapper;
using Domain.Models;
using System.Data;
using TranSPEiApiModGes.Application.Common.Interfaces.Persistence;
using TranSPEiApiModGes.Domain.Aggregates;
using TranSPEiApiModGes.Application.Customers.Commands.AddAccountCredit;
using Domain.Domains;
using System.Security.Principal;
using TranSPEiApiModGes.Application.Common.Errors;
using TranSPEiApiModGes.Application.Adminstrator.Response.Commands;

namespace TranSPEiApiModGes.Infrastructure.Presistence;

public class OrdersRepository : IOrdersRepository
{
    private readonly ApplicationContext _context;

    public OrdersRepository(ApplicationContext context)
    {
        _context = context;
    }

    //TODO: Agregar método para llamar a procedimiento almacenador
    public async Task<OrderAggregate> Create(/* TODO: Modelo o parametros */)
    {
        using (var db = _context.CreateConnection())
        {
            
        }
    }
}

