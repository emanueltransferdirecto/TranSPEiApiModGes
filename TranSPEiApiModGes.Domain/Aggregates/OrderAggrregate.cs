using System;
using Domain.Domains;
using Domain.Models;

namespace TranSPEiApiModGes.Domain.Aggregates;

public class OrderAggregate
{
    public int IdOrdenante { get; set; }
    public int IdBeneficiario { get; set; }
    public int IdOrdenanteCuenta { get; set; }
    public int IdBeneficiarioCuenta { get; set; }
    public string? ClaveSPEI { get; set; }
    public string? Concepto { get; set; }
    public decimal Monto { get; set; }
    public decimal IVA { get; set; }
    public string? ReferenciaNumerica { get; set; }
    public string? ReferenciaCobranza { get; set; }
}

