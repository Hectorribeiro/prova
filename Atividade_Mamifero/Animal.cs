using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Mamifero
{
    class Animal
    {
        private string nome;

        public Animal(string nome)
        {
            this.Nome = nome;
        }

        public global::System.String Nome { get => nome; set => nome = value; }

        public void acordar()
        {
            Console.Writeline("Animal acordou");
        }
        public void comer()
        {
            Console.Writeline("Animal comeu");
        }
        public void dormir()
        {
            Console.Writeline("Animal dormiu");
        }
    }
}
