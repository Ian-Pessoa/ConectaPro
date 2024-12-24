namespace ConectaPro.Models
{
    public class ReviewModel
    {
        public Guid Id { get; set; }
        public Guid TransactionId { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; }

        public TransactionModel Transaction { get; set; }
    }
}
