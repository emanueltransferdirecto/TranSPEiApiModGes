using System;
using System.ComponentModel.DataAnnotations;

namespace TranSPEiApiModGes.Contracts.Adminstrator;

public record AddAccountCreditRequest(
    [Required]
    int AccountId,
    decimal Amount);


