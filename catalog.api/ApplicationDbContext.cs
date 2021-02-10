using catalog.api.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace catalog.api
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            SeedData(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Product>()
                .HasData(new List<Product>
                {
                    new Product{Id = 1, Name = "MacBook"
                                , Description="Apple MacBook Pro is a macOS laptop with a 13.30-inch display that has a resolution of 2560x1600 pixels"
                                , Quantity=10
                                , PurchasePrice=2000
                                , SalePrice=2300},
                    new Product{Id = 2, Name = "Apple - AirPods Pro - White"
                                , Description="Active noise cancellation for immersive sound. Transparency mode for hearing and connecting with the world around you"
                                , Quantity=10
                                , PurchasePrice=150
                                , SalePrice=190},
                    new Product{Id = 3, Name = "Smart Android TV Sony - 77 TV Class A9G OLED 4K UHD "
                                , Description="Bring a theater experience to your home with this Sony BRAVIA 77-inch OLED 4K HDR TV."
                                , Quantity=10
                                , PurchasePrice=3500
                                , SalePrice=3900},
                    new Product{Id = 4, Name = "iPhone 12"
                                , Description="The iPhone 12 features a 6.1-inch (15.3-cm) display with Super Retina XDR OLED technology at a resolution of 2532×1170 pixels and a pixel density of about 460 ppi"
                                , Quantity=10
                                , PurchasePrice=900
                                , SalePrice=1200}

                });



        }

        public DbSet<Product> Products { get; set; }

    }
}
