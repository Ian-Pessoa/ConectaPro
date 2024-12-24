using System.Text.Json.Serialization;

namespace ConectaPro.Models
{
    public class UserModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Phone { get; set; }
        public string Usertype { get; set; }
        public string PaymentInfo { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpadtedAt { get; set; }

        [JsonIgnore]
        public ICollection<ServiceModel> Services { get; set; }
        public ICollection<NotificationModel> Notifications { get; set; }
    }
}
