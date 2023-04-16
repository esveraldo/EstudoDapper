using EstudoDapper.Domain.Entities;
using FluentValidation;

namespace EstudoDapper.Domain.Validations
{
    public class ClienteValidation : AbstractValidator<Cliente>
    {
        public ClienteValidation()
        {
            RuleFor(c => c.Id)
                .NotEmpty()
                .WithMessage("ID é obrigatório.");

            RuleFor(c => c.Nome)
                .NotEmpty()
                .WithMessage("O nome é obrigatório.");

            RuleFor(c => c.Email)
                .NotEmpty()
                .EmailAddress()
                .WithMessage("Endereço de email inválido.");

            RuleFor(c => c.Renda)
                .NotEmpty()
                .WithMessage("A renda é obrigatória.");
        }
    }
}
