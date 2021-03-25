using FluentApi.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentApi.Config
{
    public class ProductConfiguration
    {
        public ProductConfiguration(EntityTypeBuilder<Product> product)
        {
            product.HasKey(x => x.Id);
            product.Property(x => x.Nombre).HasMaxLength(50).IsRequired();
            product.Property(x => x.Precio).IsRequired();
            product.Property(x => x.Descripcion).HasMaxLength(100);
            product.Property(x => x.Imagen).HasMaxLength(150);
            product.Property(x => x.Categpria).IsRequired();
        }
    }
}
