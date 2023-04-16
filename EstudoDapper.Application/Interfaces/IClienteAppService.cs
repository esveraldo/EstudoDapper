using EstudoDapper.Application.Commands.Clientes;
using EstudoDapper.Application.Queries.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoDapper.Application.Interfaces
{
    public interface IClienteAppService : IDisposable
    {
        ClienteQuery Add(CriarClienteCommand command);
    }
}
