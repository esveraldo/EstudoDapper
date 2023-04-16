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
    public class PessoaJuridica : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string Cnpj { get; set; }
        public string Ramo { get; set; }
        public Cliente Cliente { get; set; }
        public Guid ClienteId { get; set; }

        public ValidationResult Validate => new PessoaJuridicaValidation().Validate(this);
    }
}
