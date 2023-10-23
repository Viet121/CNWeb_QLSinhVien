using System.Net;
using Microsoft.EntityFrameworkCore;

namespace backend.Models
{
    public class DatabaseContext : DbContext
    {
        
        public DbSet<Khoa> khoas {get; set;}
        public DatabaseContext (DbContextOptions<DatabaseContext> options) : base (options) {

        }
    }
}