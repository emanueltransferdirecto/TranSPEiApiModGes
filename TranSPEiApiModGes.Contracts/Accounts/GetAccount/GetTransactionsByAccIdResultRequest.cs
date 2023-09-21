using System;
using System.ComponentModel.DataAnnotations;

namespace TranSPEiApiModGes.Contracts.Accounts;

public record GetTransactionsByAccIdResultRequest([Required]int AccountId);


