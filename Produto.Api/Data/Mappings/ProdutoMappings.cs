using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Produto.Api.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Produto.Api.Data.Mappings
{
    public class ProdutoMappings : IEntityTypeConfiguration<Produtos>
    {
        public void Configure(EntityTypeBuilder<Produtos> builder)
        {
            builder.HasKey(p => p.Id);


            builder.Property(p => p.nome)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(p => p.tipo)
                .HasColumnType("varchar(50)");

            builder.Property(p => p.preco)
               .IsRequired()
               .HasColumnType("decimal");

            builder.Property(p => p.quantidade)
               .IsRequired()
               .HasColumnType("int");

            builder.Property(p => p.marca)
               .HasColumnType("varchar(200)");

            builder.ToTable("Produto");



        }
    }
}
