using System;
using Microsoft.EntityFrameworkCore;

namespace FeastFreedom.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<KitchenUsers> KitchenUsers { get; set; }
        public DbSet<MenuItems> MenuItems { get; set; }
        public DbSet<Regular_Users> Regular_Users { get; set; }
        public DbSet<SecurityQuestions> SecurityQuestions { get; set; }

    }
}
