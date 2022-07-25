﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InvestmentPortfolio.Models
{
    public class RiskLevel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
