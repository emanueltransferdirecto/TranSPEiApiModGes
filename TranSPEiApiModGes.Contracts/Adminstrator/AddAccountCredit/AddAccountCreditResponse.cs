﻿using System;
using System.ComponentModel.DataAnnotations;

namespace TranSPEiApiModGes.Application.Adminstrator;

public record AddAccountCreditResponse(
    string TransactionId,
    int RetrieverAccount,
    DateTime Date,
    string Operation,
    decimal Amount,
    decimal Balance);


