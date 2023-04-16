using EstudoDapper.Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoDapper.Domain.Validations
{
    public class ConjugeValidation : AbstractValidator<Conjuge>
    {
        public ConjugeValidation()
        {
            RuleFor(c => c.Nome)
                .NotEmpty()
                .WithMessage("O nome é obrigatório");

            RuleFor(c => c.Telefone)
                .NotEmpty()
                .WithMessage("O telefone é obrigatório");

            RuleFor(c => c.CodCliente)
                .NotEmpty()
                .WithMessage("O CodCliente é obrigatório");
        }
    }
}
