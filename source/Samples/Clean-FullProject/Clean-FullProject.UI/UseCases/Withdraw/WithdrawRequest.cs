﻿namespace Clean_FullProject.UI.UseCases.Withdraw
{
    using System;
    public class WithdrawRequest
    {
        public Guid AccountId { get; set; }
        public Double Amount { get; set; }
    }
}