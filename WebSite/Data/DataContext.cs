using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;
using WebSite.Models;

namespace ContosoUniversity.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        //public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Ad> Ads { get; set; }

    }
}