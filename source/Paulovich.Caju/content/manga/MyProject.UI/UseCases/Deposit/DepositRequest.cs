﻿namespace MyProject.UI.UseCases.Deposit
{
    using System;
    public class DepositRequest
    {
        public Guid AccountId { get; set; }
        public Double Amount { get; set; }
    }
}
