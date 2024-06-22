using CKEditorIntegrationInAspNetCore.Models;
using Microsoft.EntityFrameworkCore;

namespace CKEditorIntegrationInAspNetCore.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }
    }
}
