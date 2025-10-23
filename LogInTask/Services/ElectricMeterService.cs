using LogInTask.Models;

namespace LogInTask.Services
{
    public class ElectricMeterService : IElectricMeterService
    {

        public async Task<MeterQueryResponse> QueryMeterAsync(MeterQueryRequest request)
        {
            await Task.Delay(1000);

            if (string.IsNullOrWhiteSpace(request.MeterNo))
            {
                return new MeterQueryResponse
                {
                    Success = false
                };
            }

            var resp = new MeterQueryResponse
            {
                AccountNumber = "100166299",
                AccountUsed = "2522",
                CustomerName = "صالح",
                MeterNumber = request.MeterNo,
                QueryRef = Guid.NewGuid().ToString("N").Substring(0, 10),
                Adjustments = 19.6m,
                RechargeAmount = Math.Max(0, request.Amount.HasValue ? request.Amount.Value - 19.6m : 0),
                Success = true,
                Timestamp = DateTime.UtcNow,
                AdjustmentsDetails = new List<AdjustmentDetail>
                {
                    new AdjustmentDetail
                    {
                        AdjustmentName = "رسوم جباية نفايات",
                        AdjustmentRemains = "0.0",
                        AdjustmentValue = "19.6"
                    }
                }
            };

            return resp;
        }

        public async Task<PaymentResponse> ProcessPaymentAsync(MeterQueryRequest request)
        {
            await Task.Delay(1200);

            var result = new PaymentResponse
            {
                Success = true,
                MeterNumber = request.MeterNo,
                CustomerName = "أحمد محمد",
                AccountNumber = 123456789,
                AmountPaid = (decimal)request.Amount,
                UnitsAdded = Math.Round((decimal)(request.Amount / 3.2m), 2),
                Token = Guid.NewGuid().ToString(),
                ReferenceNumber = $"rtr_{DateTime.UtcNow:yyyyMMdd_HHmmss}",
                AccountUsed = "account_username",
                Timestamp = DateTime.UtcNow
            };

            return result;
        }


    }
}
