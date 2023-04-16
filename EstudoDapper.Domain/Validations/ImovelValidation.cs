using EstudoDapper.Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoDapper.Domain.Validations
{
    public class ImovelValidation : AbstractValidator<Imovel>
    {
        public ImovelValidation()
        {
            RuleFor(i => i.Tipo)
                .NotEmpty()
                .WithMessage("Informe o tipo.");

            RuleFor(i => i.Area)
                .NotEmpty()
                .WithMessage("Informe a área.");

            RuleFor(i => i.Valor)
                .NotEmpty()
                .WithMessage("Informe o valor.");
        }
    }
}
