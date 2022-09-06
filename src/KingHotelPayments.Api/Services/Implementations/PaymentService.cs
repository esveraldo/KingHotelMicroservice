using KingHotelPayments.Api.Models;
using KingHotelPayments.Api.Services.Interfaces;

namespace KingHotelPayments.Api.Services.Implementations
{
    public class PaymentService : IPaymentService
    {
        public Task<bool> Process(PaymentsInfoInputModel paymentInfoInputModel)
        {
            return Task.FromResult(true);
        }
    }
}
