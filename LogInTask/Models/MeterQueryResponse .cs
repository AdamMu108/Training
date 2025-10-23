using System;
using System.Collections.Generic;
using LogInTask.Models;

namespace LogInTask.Models
{
    public class MeterQueryResponse
    {
        public string AccountNumber { get; set; } = string.Empty;
        public string AccountUsed { get; set; } = string.Empty;
        public string CustomerName { get; set; } = string.Empty;
        public string MeterNumber { get; set; } = string.Empty;
        public string QueryRef { get; set; } = string.Empty;
        public decimal Adjustments { get; set; }
        public decimal RechargeAmount { get; set; }
        public bool Success { get; set; }
        public DateTime Timestamp { get; set; }
        public List<AdjustmentDetail> AdjustmentsDetails { get; set; } = new();
    }
}
