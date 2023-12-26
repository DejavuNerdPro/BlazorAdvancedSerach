using BlazorAdvancedSerach.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorAdvancedSerach.DatabaseContext
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        public DbSet<User> User { get; set; }

    }
}
