using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos
{
    public class Usuario
    {
        public string Email;
        public string Senha;
        public string Nome;

        public Usuario()
        {

        }

        public void Logar()
        {
            Console.WriteLine("Usuário Logou");
        }
    }
}
