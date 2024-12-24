namespace ConectaPro.Models
{
    public class ServiceModel
    {
        public Guid Id { get; set; }
        public Guid ProviderId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal HourlyRate { get; set; }
        public double Rating { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public UserModel Provider { get; set; }
    }
}
