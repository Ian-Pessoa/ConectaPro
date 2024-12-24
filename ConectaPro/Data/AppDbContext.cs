using ConectaPro.Models;
using Microsoft.EntityFrameworkCore;

namespace ConectaPro.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<NotificationModel> Notifications { get; set; }
        public DbSet<PaymentModel> Payments { get; set; }
        public DbSet<ReviewModel> Reviews { get; set; }
        public DbSet<ServiceModel> Services { get; set; }
        public DbSet<TransactionModel> Transactions { get; set; }
        public DbSet<UserModel> Users { get; set; }


    }
}
