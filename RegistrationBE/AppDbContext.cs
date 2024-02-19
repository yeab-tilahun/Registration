using Microsoft.EntityFrameworkCore;
using RegistrationBE.Models;
namespace RegistrationBE
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
    }
}