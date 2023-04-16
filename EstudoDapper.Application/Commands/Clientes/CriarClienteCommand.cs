using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoDapper.Application.Commands.Clientes
{
    public class CriarClienteCommand
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public Decimal Renda { get; set; }
    }
}
