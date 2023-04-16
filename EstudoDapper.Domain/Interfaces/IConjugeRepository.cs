using EstudoDapper.Domain.Core;
using EstudoDapper.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoDapper.Domain.Interfaces
{
    public interface IConjugeRepository : IBaseRepository<Conjuge, Guid>
    {
    }
}
