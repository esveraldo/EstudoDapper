using EstudoDapper.Domain.Core;
using EstudoDapper.Domain.Validations;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoDapper.Domain.Entities
{
    public class Cliente : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public Decimal Renda { get; set; }

        public ICollection<PessoaFisica> PessoaFisica { get; set; }
        public ICollection<PessoaJuridica> PessoaJuridica { get; set; }
        public ICollection<Imovel> Imovel { get; set; }
        public ICollection<Conjuge> Conjuge { get; set; }

        public ValidationResult Validate => new ClienteValidation().Validate(this);
    }
}
