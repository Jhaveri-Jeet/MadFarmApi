using MedFarmApi.Features.Cattle;
using MedFarmApi.Features.Category;
using Microsoft.EntityFrameworkCore;
using MedFarmApi.Features.Product;
using MadFarmApi.Features.User;
using MadFarmApi.Features.Cart;

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
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Cart> Cart { get; set; }

    }

}
