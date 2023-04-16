using AutoMapper;
using EstudoDapper.Application.Commands.Clientes;
using EstudoDapper.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoDapper.Application.Mappings
{
    public class CommandToModelMap : Profile
    {
        public CommandToModelMap()
        {
            CreateMap<CriarClienteCommand, Cliente>()
                .AfterMap((command, model) => { model.Id = Guid.NewGuid(); });
        }
    }
}
