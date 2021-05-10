using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Calculadora1
    {
        private int soma;
        private int subtracao;
        private int divisao;
        private int multiplicacao;

        public global::System.Int32 Soma { get => this.soma; set => this.soma = value; }
        public global::System.Int32 Subtracao { get => this.subtracao; set => this.subtracao = value; }
        public global::System.Int32 Divisao { get => this.divisao; set => this.divisao = value; }
        public global::System.Int32 Multiplicacao { get => this.multiplicacao; set => this.multiplicacao = value; }

        public Calculadora1(int soma,int subtracao,int divisao,int multiplicacao)
        {

        }

       public void soma(int num1, int num2)
        {
            soma = num1 + num2;
        }

        public void subtracao(int num1, int num2)
        {
            subtracao = num1 - num2;
        }

        public void multiplicacao(int num1, int num2)
        {
            multiplicacao = num1 * num2;
        }
        public void divisao(int num1, int num2)
        {
            divisao = num1 / num2;
        }



    }
}
