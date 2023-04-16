using EstudoDapper.Domain.Core;
using EstudoDapper.Domain.Validations;
using FluentValidation.Results;

namespace EstudoDapper.Domain.Entities
{
    public class PessoaFisica : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string Cpf { get; set; }
        public string Sexo { get; set; }
        public Cliente Cliente { get; set; }
        public Guid ClienteId { get; set; }

        public ValidationResult Validate => new PessoaFisicaValidation().Validate(this);
    }
}
