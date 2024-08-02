using System.Data.Entity; // Usar EF6
using ventasControl.Models;

namespace ventasControl.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("name=DefaultConnection") // La cadena de conexión se configura en Web.config
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<SalesProduct> SalesProducts { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configurar las relaciones entre SalesProduct y Product/Sale
            modelBuilder.Entity<SalesProduct>()
                .HasRequired(sp => sp.Product)
                .WithMany(p => p.SalesProducts)
                .HasForeignKey(sp => sp.ProductsId);

            modelBuilder.Entity<SalesProduct>()
                .HasRequired(sp => sp.Sale)
                .WithMany(s => s.SalesProducts)
                .HasForeignKey(sp => sp.SalesId);
        }
    }
}
