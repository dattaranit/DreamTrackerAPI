using DreamTrackerAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace DreamTrackerAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> Users { get; set; }
    }
}
