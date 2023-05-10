using AutoMapper;
using EstudoDapper.Application.Commands.Clientes;
using EstudoDapper.Domain.Entities;

namespace EstudoDapper.Application.Mappings
{
    public class CommandToModelMap : Profile
    {
        public CommandToModelMap()
        {
            CreateMap<CriarClienteCommand, Cliente>()
                .AfterMap((command, model) => { model.Id = Guid.NewGuid(); });

            CreateMap<AtualizarClienteCommand, Cliente>();

        }
    }
}
