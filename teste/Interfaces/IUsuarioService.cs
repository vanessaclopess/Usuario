using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Usuario.Application.Dto;

namespace Usuario.Application.Interfaces
{
    public interface IUsuarioService
    {
        void Add(string login, string password);

        Task<List<UsuarioDto>> Get();

        Task<UsuarioDto> GetById(Guid id);
    }
}
