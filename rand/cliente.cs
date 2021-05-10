using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rand
{
    class cliente:pessoa
    {
        private string clientType;

        public client(string nome, char sexo , int idade, long cpf,string clientType): base(nome,idade,sexo,cpf,)
        {
            this.ClientType = clientType;

        }

        public global::System.String ClientType { get => clientType; set => clientType = value; }
    }
}
