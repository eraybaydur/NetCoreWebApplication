using Entities;
using Microsoft.EntityFrameworkCore;

namespace NetCoreWebApplication.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<User> Users { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=KurumsalWeb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    Id = 1,
                    CreateDate = DateTime.Now,
                    IsActive = true,
                    Name = "Admin",
                    Surname = "Admin",
                    Phone = "1234567890",
                    Password = "123456",
                    Username = "Admin",
                    Email = "admin@admin.com"
                }

                );
            base.OnModelCreating(modelBuilder);
        }

    }
}
