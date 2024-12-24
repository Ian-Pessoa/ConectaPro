namespace ConectaPro.Models
{
    public class PaymentModel
    {
        public Guid Id { get; set; }
        public Guid TransactionId { get; set; }
        public decimal Amount { get; set; }
        public string Method { get; set; }
        public string PaymentStatus { get; set; }
        public DateTime CreatedAt { get; set; }

        public TransactionModel Transaction { get; set; }
    }
}
