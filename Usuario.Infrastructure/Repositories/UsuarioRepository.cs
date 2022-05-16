using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Usuario.Domain.Entities;
using Usuario.Infrastructure.Context;
using Usuario.Infrastructure.Interfaces;

namespace Usuario.Infrastructure.Repositories
{
    public class UsuarioRepository : RepositoryBase<UsuarioEntity>, IUsuarioRepository
    {
        public UsuarioRepository(UsuarioContext context) : base(context)
        {
        }
    }
}
