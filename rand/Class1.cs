using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rand
{
    class pessoa
    {//atributos
        private string nome;
        private int idade;
        private char sexo;
        private long cpf;

        public pessoa() { }

        public pessoa(string nome, int idade,char sexo,long cpf)
        {
            this.Nome;
            this.Idade;
            this.Sexo;
            this.Cpf;
        }
        //metodos get e set
        public global::System.String Nome { get => nome; set => nome = value; }
        public global::System.Int32 Idade { get => idade; set => idade = value; }
        public global::System.Char Sexo { get => sexo; set => sexo = value; }
        public global::System.Int64 Cpf { get => cpf; set => cpf = value; }
    }
}
