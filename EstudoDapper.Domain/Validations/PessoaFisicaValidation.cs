using EstudoDapper.Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoDapper.Domain.Validations
{
    public class PessoaFisicaValidation : AbstractValidator<PessoaFisica>
    {
        public PessoaFisicaValidation()
        {
            RuleFor(pf => pf.Cpf)
                .NotEmpty()
                .WithMessage("Informe o CPF.");

            RuleFor(pf => pf.Sexo)
                .NotEmpty()
                .WithMessage("Informe o Sexo.");
        }
    }
}
