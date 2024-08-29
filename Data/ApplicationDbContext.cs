using fproject.Models;
using Microsoft.EntityFrameworkCore;

namespace fproject.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : 
            base(options) { }

        public DbSet<Guest> guests { get; set; }
    }
}
