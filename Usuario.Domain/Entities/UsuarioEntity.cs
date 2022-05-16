using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuario.Domain.Entities
{
    public class UsuarioEntity : EntityBase
    {
        public string Login { get; set; }

        public string Nome { get; set; }

        public string Endereco { get; set; }

        public string Password { get; set; }

        public UsuarioEntity(string login, string nome, string endereco, string password)
        {
            Login = login;
            Password = password;      
            Nome = nome;
            Endereco = endereco;

        }
    }
}
