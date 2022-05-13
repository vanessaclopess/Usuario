using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Usuario.Application.Dto;
using Usuario.Application.Interfaces;
using Usuario.Infrastructure.Interfaces;

namespace Usuario.Application.Services
{
    //public class UsuarioService : IUsuarioService
    //{
    //    private readonly IUsuarioRepository _repository;

    //    public UsuarioService(IUsuarioRepository repository)
    //    {
    //        _repository = repository;
    //    }

    //    public void Add(string login, string telefone, string nome, string endereco, string password) => _repository.Add(new Domain.Entities.UsuarioEntity(login, telefone, nome, endereco, password));

    //    public async Task<List<UsuarioDto>> Get()
    //    {
    //        var result = await _repository.Get();

    //        return result.Select(x => new UsuarioDto(x.Id, x.Login, x.Password)).ToList();
    //    }

    //    public async Task<UsuarioDto> GetById(Guid id)
    //    {
    //        var result = await _repository.GetByGuid(id);

    //        return new UsuarioDto(result.Id, result.Login, result.Password);
    //    }
    //}
}
