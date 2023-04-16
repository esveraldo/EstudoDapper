using FluentValidation.Results;

namespace EstudoDapper.Domain.Core
{
    public interface IEntity<TKey>
    {
        /// <summary>
        /// Identificador da entidade
        /// </summary>
        public TKey Id { get; set; }

        /// <summary>
        /// Retornar o resumo da validação da entidade
        /// </summary>
        ValidationResult Validate { get; }

    }
}
