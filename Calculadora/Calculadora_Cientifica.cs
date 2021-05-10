using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Calculadora_Cientifica
    {
        private int raiz;

        public void raiz(int num)
        {
            raiz = num * num;
        }

        public global::System.Int32 Raiz { get => raiz; set => raiz = value; }
    }
}
