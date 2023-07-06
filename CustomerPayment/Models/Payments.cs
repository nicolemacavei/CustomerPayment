using System.ComponentModel.DataAnnotations;

namespace CustomerPayment.Models
{
    public class Payments
    {
        public Payments(int id, string customerId, string paymentType)
        {
            Id = id;
            CustomerId = customerId;
            PaymentType = paymentType;
        }

        public int Id { get; set; }
        [Required]
        public string CustomerId { get; set; }
        = string.Empty;
        [Required]

        public string PaymentType { get; set; }
    }
}
