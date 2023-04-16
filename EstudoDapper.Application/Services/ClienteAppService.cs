using AutoMapper;
using EstudoDapper.Application.Commands.Clientes;
using EstudoDapper.Application.Interfaces;
using EstudoDapper.Application.Queries.Clientes;
using EstudoDapper.Domain.Entities;
using EstudoDapper.Domain.Interfaces;
using FluentValidation;

namespace EstudoDapper.Application.Services
{
    public class ClienteAppService : IClienteAppService
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IMapper _mapper;

        public ClienteAppService(IClienteRepository clienteRepository, IMapper mapper)
        {
            _clienteRepository = clienteRepository;
            _mapper = mapper;
        }

        public ClienteQuery Add(CriarClienteCommand command)
        {
            var cliente = _mapper.Map<Cliente>(command);

            var validate = cliente.Validate;
            if (!validate.IsValid)
                throw new ValidationException(validate.Errors);

            _clienteRepository.Create(cliente);

            return _mapper.Map<ClienteQuery>(cliente);
        }

        public void Dispose()
        {
            _clienteRepository.Dispose();
        }
    }
}
