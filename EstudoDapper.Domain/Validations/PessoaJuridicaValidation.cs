using EstudoDapper.Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoDapper.Domain.Validations
{
    public class PessoaJuridicaValidation : AbstractValidator<PessoaJuridica>
    {
        public PessoaJuridicaValidation()
        {
            RuleFor(pj => pj.Cnpj)
                .NotEmpty()
                .WithMessage("Informe o CNPJ.");

            RuleFor(pj => pj.Ramo)
                .NotEmpty()
                .WithMessage("Informe o Ramo.");
        }
    }
}
