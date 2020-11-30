using Microsoft.EntityFrameworkCore;
using sama.Models;

namespace sama.Data
{
    public class MvcUserContext : DbContext
    {
        public MvcUserContext (DbContextOptions<MvcUserContext> options)
            : base(options)
        {
        }

        public DbSet<user> User { get; set; }
    }
}