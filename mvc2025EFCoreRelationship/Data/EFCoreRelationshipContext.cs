using Microsoft.EntityFrameworkCore;
using mvc2025EFCoreRelationship.Models;

namespace mvc2025EFCoreRelationship.Data
{
    public class EFCoreRelationshipContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public EFCoreRelationshipContext(DbContextOptions<EFCoreRelationshipContext> options) : base(options)
        {

            
        }
    }
}
