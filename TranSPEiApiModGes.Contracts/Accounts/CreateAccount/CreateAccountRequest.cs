﻿using System;
using System.ComponentModel.DataAnnotations;

namespace TranSPEiApiModGes.Contracts.Accounts;

public record CreateAccountRequest(
    int AccountTypesId,
    string Frequency);


