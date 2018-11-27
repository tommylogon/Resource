using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Resource.Models
{
    public class ResourceContext : DbContext
    {
        public ResourceContext (DbContextOptions<ResourceContext> options)
            : base(options)
        {
        }

        public DbSet<Resource.Models.Customer> Customer { get; set; }
    }
}
