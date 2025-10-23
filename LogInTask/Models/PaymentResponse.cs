namespace LogInTask.Models
{
    public class PaymentResponse
    {
        public bool Success { get; set; }
        public string MeterNumber { get; set; } = string.Empty;
        public string CustomerName { get; set; } = string.Empty;
        public decimal AccountNumber { get; set; }
        public string Token { get; set; } = string.Empty;
        public string ReferenceNumber { get; set; } = string.Empty;
        public string AccountUsed { get; set; } = string.Empty;
        public decimal AmountPaid { get; set; }
        public decimal UnitsAdded { get; set; }
        public DateTime Timestamp { get; set; }
    }

}
