namespace ConectaPro.Models
{
    public class NotificationModel
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Message { get; set; }
        public string Type { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ReadAt { get; set; }

        public UserModel User { get; set; }
    }
}
