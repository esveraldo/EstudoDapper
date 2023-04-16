using EstudoDapper.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoDapper.Infraesturcture.Data.Mappings
{
    public class ConjugeMap : IEntityTypeConfiguration<Conjuge>
    {
        public void Configure(EntityTypeBuilder<Conjuge> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .HasColumnType("varchar(150)");

            builder.Property(x => x.Telefone)
                .HasColumnType("varchar(20)");

            builder.Property(x => x.CodCliente)
                .HasColumnType("varchar(30)");
        }
    }
}
