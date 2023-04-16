using AutoMapper;
using EstudoDapper.Application.Queries.Clientes;
using EstudoDapper.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoDapper.Application.Mappings
{
    public class ModelToQueryMap : Profile
    {
        public ModelToQueryMap()
        {
            CreateMap<Cliente, ClienteQuery>();
        }
    }
}
