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
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ClienteAppService(IClienteRepository clienteRepository, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _clienteRepository = clienteRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<List<ClienteQuery>> GetAll()
        {
            var clientes = await _clienteRepository.GetAll();
            return _mapper.Map<List<ClienteQuery>>(clientes.ToList());
        }

        public async Task<ClienteQuery> GetById(Guid id)
        {
            var cliente = await _clienteRepository.GetById(id);
            return _mapper.Map<ClienteQuery>(cliente);
        }

        public async Task<ClienteQuery> Add(CriarClienteCommand command)
        {
            var cliente = _mapper.Map<Cliente>(command);

            var validate = cliente.Validate;
            if (!validate.IsValid)
                throw new ValidationException(validate.Errors);

            await _clienteRepository.Create(cliente);
            _unitOfWork.Commit();

            return _mapper.Map<ClienteQuery>(cliente);
        }

        public async Task<ClienteQuery> Update(AtualizarClienteCommand command)
        {
            var cliente = await _clienteRepository.GetById(command.Id);
            cliente.Nome = command.Nome;
            cliente.Email = command.Email;
            cliente.Renda = command.Renda;

            var clienteAtualizado = _mapper.Map<Cliente>(command);


            var validate = clienteAtualizado.Validate;
            if (!validate.IsValid)
                throw new ValidationException(validate.Errors);

            await _clienteRepository.Update(clienteAtualizado);
            _unitOfWork.Commit();

            return _mapper.Map<ClienteQuery>(clienteAtualizado);
        }

        public async Task<ClienteQuery?> Remove(Guid id)
        {
            var cliente = await _clienteRepository.GetById(id);
            await _clienteRepository.Delete(cliente);
            _unitOfWork.Commit();

            return null;
        }

        public void Dispose()
        {
            _clienteRepository.Dispose();
        }
    }
}
