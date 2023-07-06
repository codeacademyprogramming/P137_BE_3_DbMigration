using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.DAL
{
    public class UniversityDbContext:DbContext
    {
        public UniversityDbContext(DbContextOptions<UniversityDbContext> options):base(options)
        {
            
        }

        public DbSet<Student> Students { get; set; }
    }
}
