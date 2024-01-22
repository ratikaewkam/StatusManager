using Microsoft.EntityFrameworkCore;
using StatusManager.Models;

namespace StatusManager.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
        } 

        public DbSet<TaskData> Tasks { get; set; }
    }
}
