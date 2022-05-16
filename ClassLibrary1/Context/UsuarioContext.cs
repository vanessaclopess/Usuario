using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Usuario.Domain.Entities;

namespace ClassLibrary1.Context
{
    public class UsuarioContext : DbContext
    {
        public UsuarioContext(DbContextOptions options) : base(options) { }

        public DbSet<UsuarioEntity> UsuarioEntity { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
