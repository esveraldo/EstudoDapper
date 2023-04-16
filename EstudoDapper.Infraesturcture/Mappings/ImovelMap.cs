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
    public class ImovelMap : IEntityTypeConfiguration<Imovel>
    {
        public void Configure(EntityTypeBuilder<Imovel> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Area)
                .HasColumnType("decimal(8,2)");

            builder.Property(x => x.Tipo)
                .HasColumnType("varchar(20)");

            builder.Property(x => x.Valor)
                .HasColumnType("decimal(8,2)")
                .IsRequired();
        }
    }
}
