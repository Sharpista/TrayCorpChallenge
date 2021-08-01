using Flunt.Notifications;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrayCorpChallenge.Domain.Enitites;

namespace TrayCorpChallenge.DataAcess.Context
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProductContext).Assembly);
            base.OnModelCreating(modelBuilder);
            modelBuilder.Ignore<Notification>();

            modelBuilder.Entity<Product>().HasData(
                new Product("Aspirador de Pó", true, 100.00M),
                new Product("Casaco", true, 30.00M), 
                new Product("Abajur", true, 20.00M), 
                new Product("Comoda", true, 350.00M),
                new Product("Espelho", true, 80.00M) );
            
        }
    }
}
