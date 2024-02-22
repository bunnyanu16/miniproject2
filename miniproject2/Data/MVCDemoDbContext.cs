using Microsoft.EntityFrameworkCore;
using Miniproject2.Models.Domain;

namespace Miniproject2.Data
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<Student> Students { get; set; }
    }
    
}
