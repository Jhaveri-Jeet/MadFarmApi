using MedFarmApi.Features.Cattle;
using MedFarmApi.Features.Category;
using Microsoft.EntityFrameworkCore;
using MedFarmApi.Features.Product;

namespace MedFarmApi.Features.Shared
{
    public class DatabaseContext : DbContext
    {
        protected DatabaseContext()
        {
        }
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<Cattles> Cattles { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }

        public virtual DbSet<Products> Products { get; set; }

    }

}
