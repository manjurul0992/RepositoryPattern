
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RepositoryFaisal.Models;

namespace RepositoryFaisal.Data
{
    public class ApplicationDbContext: /*DbContext*/ IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base (options)
        {
            
        }
        public DbSet<Product> Products { get; set; }
    }
}
