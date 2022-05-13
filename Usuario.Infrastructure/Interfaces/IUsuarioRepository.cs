using Usuario.Domain.Entities;

namespace Usuario.Infrastructure.Interfaces
{
    public interface IUsuarioRepository : IRepositoryAsync<UsuarioEntity>
    { }
}
