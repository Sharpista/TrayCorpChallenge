using Flunt.Notifications;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrayCorpChallenge.Domain.Enitites;

namespace TrayCorpChallenge.DataAcess.Mapping
{
    public class ProductMapping : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Name)
                .IsRequired();
            builder
                .Property(x => x.Inventory);
            builder
                .Property(x => x.Value)
                .HasPrecision(18, 2);

          



        }
    }
}
