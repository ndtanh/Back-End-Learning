﻿using System;
using AriProject.Domain.SharedKernel;

namespace AriProject.Domain.ForeignExchange
{
    public class ConversionRate
    {
        public string SourceCurrency { get; }

        public string TargetCurrency { get; }

        public decimal Factor { get; }

        public ConversionRate(string sourceCurrency, string targetCurrency, decimal factor)
        {
            this.SourceCurrency = sourceCurrency;
            this.TargetCurrency = targetCurrency;
            this.Factor = factor;
        }

        internal MoneyValue Convert(MoneyValue value)
        {
            return this.Factor * value;
        }
    }
}