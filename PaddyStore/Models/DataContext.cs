using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace PaddyStore.Models
{
    public class DataContext :DbContext
    {
       private readonly IConfiguration configuration;

        public DataContext(IConfiguration _configuration)
        {
            this.configuration = _configuration;
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var ConnectionString = configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlite(ConnectionString);

        }

        public DbSet<User> Users { get; set; }






    }
}
