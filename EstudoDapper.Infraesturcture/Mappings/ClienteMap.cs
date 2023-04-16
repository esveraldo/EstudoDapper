using EstudoDapper.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EstudoDapper.Infraesturcture.Data.Mappings
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .HasColumnType("varchar(150)");

            builder.Property(x => x.Email)
                .HasColumnType("varchar(150)");

            builder.Property(x => x.Renda)
                .HasColumnType("decimal(8,2)");

            builder.HasMany(p => p.PessoaFisica)
                .WithOne(c => c.Cliente)
                .HasForeignKey(f => f.ClienteId);

            builder.HasMany(p => p.PessoaJuridica)
                .WithOne(c => c.Cliente)
                .HasForeignKey(f => f.ClienteId);

            builder.HasMany(m => m.Imovel)
                .WithOne(c => c.Cliente)
                .HasForeignKey(f => f.ClienteId);

            builder.HasMany(c => c.Conjuge)
                .WithOne(c => c.Cliente)
                .HasForeignKey(f => f.ClienteId);
        }
    }
}
