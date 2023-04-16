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
    public class PessoaJuridicaMap : IEntityTypeConfiguration<PessoaJuridica>
    {
        public void Configure(EntityTypeBuilder<PessoaJuridica> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(x => x.Cnpj)
                .HasColumnType("varchar(20)");

            builder.Property(x => x.Ramo)
                .HasColumnType("char(1)");
        }
    }
}
