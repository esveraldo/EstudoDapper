using AutoMapper;
using EstudoDapper.Application.Queries.Clientes;
using EstudoDapper.Domain.Entities;

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
