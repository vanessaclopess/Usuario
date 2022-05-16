using Microsoft.EntityFrameworkCore;
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
    public class RepositoryBase<T> : IRepositoryAsync<T> where T : EntityBase
    {
        private readonly UsuarioContext _context;

        public RepositoryBase(UsuarioContext context)
        {
            _context = context;
        }

        public async Task Add(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<List<T>> Get()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetByGuid(Guid id)
        {
            return await _context.Set<T>().FirstAsync(x => x.Id == id);
        }
    }
}
