﻿using EstudoDapper.Domain.Entities;
using EstudoDapper.Domain.Interfaces;
using EstudoDapper.Infraesturcture.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoDapper.Infraesturcture.Data.Repositories
{
    public class ClienteRepository : BaseRepository<Cliente, Guid>, IClienteRepository
    {
        public ClienteRepository(EntityFrameworkContext entityFrameworkContext) : base(entityFrameworkContext)
        {
        }
    }
}
