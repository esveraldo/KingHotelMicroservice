namespace KingHotelPayments.Api.Models
{
    public class PaymentsInfoInputModel
    {
        public Guid Id { get; set; }
        public string Number { get; set; }
        public string Cvv { get; set; }
        public string Expires { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
    }
}
