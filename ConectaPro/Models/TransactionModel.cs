namespace ConectaPro.Models
{
    public class TransactionModel
    {
        public Guid Id { get; set; }
        public Guid ClientId { get; set; }
        public Guid ProviderId { get; set; }
        public Guid ServiceId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public decimal TotalPrice { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }

        public UserModel Client { get; set; }
        public UserModel Provider { get; set; }
        public ServiceModel Service { get; set; }
    }
}
