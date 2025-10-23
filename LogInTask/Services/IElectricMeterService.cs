using LogInTask.Models;

namespace LogInTask.Services
{
    public interface IElectricMeterService
    {
        Task<MeterQueryResponse> QueryMeterAsync(MeterQueryRequest request);
        Task<PaymentResponse> ProcessPaymentAsync(MeterQueryRequest request);
    }
}
