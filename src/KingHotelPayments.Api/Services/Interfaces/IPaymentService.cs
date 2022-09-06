using KingHotelPayments.Api.Models;

namespace KingHotelPayments.Api.Services.Interfaces
{
    public interface IPaymentService
    {
        Task<bool> Process(PaymentsInfoInputModel paymentInfoInputModel);
    }
}
