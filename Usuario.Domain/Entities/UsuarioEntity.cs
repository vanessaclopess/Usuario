using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuario.Domain.Entities
{
    public class UsuarioEntity
    {
        public string Login { get; set; }

        public string Telefone { get; set; }

        public string Nome { get; set; }

        public string Endereco { get; set; }

        public string Password { get; set; }

        public Guid Id { get; set; }

        public UsuarioEntity(string login, string telefone, string nome, string endereco, string password)
        {
            Login = login;
            Password = password;
            Telefone = telefone;
            Nome = nome;
            Endereco = endereco;

        }
    }
}
