using jwt11april.Models;
using Microsoft.EntityFrameworkCore;

namespace jwt11april.Context
{
    public class JwtContext:DbContext
    {
        public JwtContext(DbContextOptions<JwtContext>options):base(options)
        {
            
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
