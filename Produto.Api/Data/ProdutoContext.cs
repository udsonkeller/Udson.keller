using Microsoft.EntityFrameworkCore;
using Produto.Api.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Produto.Api.Data
{
    public sealed class ProdutoContext : DbContext

    {
        public ProdutoContext(DbContextOptions<ProdutoContext> options) : base(options)
        {

        }
                
        public DbSet<Produtos> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            foreach (var property in modelBuilder.Model.GetEntityTypes().SelectMany(
                e => e.GetProperties().Where(p => p.ClrType == typeof(string))))
                property.SetColumnType("varchar(100)");

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProdutoContext).Assembly);
        }


    }
}
