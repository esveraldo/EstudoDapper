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
    public class PessoaFisicaMap : IEntityTypeConfiguration<PessoaFisica>
    {
        public void Configure(EntityTypeBuilder<PessoaFisica> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(x => x.Cpf)
                .HasColumnType("varchar(20)");

            builder.Property(x => x.Sexo)
                .HasColumnType("char(1)");
        }
    }
}
