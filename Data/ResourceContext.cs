using Microsoft.EntityFrameworkCore;

namespace Resource.Models
{
    public class ResourceContext : DbContext
    {
        public ResourceContext(DbContextOptions<ResourceContext> options)
            : base(options)
        {
        }

        public DbSet<Resource.Models.Customer> Customer { get; set; }
    }
}