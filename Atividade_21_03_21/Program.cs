using System;

namespace Atividade_21_03_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Heitor Costa Ribeiro 24 3B1");


            Carro c1 = new Carro();
            Carro c2 = new Carro("Poste","Prata",2020,5,6,"Volkswagen",32453456345);

            c1.Marca = "Land Rover";
             
            Console.Writeline(c2.Getmodelo());
            Console.Writeline(c1.Marca);
            Console.Writeline();







        }
    }
}
