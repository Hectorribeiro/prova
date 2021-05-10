using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_21_03_21
{
    class Carro
    {
       private string modelo;
       private string cor;
       private int ano;
       private string marca;
       private long chassi;
       private double velocidadeMaxima;
       private double velocidadeAtual;
       private int numPortas;
       private int numMarchas;
       private int marchaAtual;
       private string tipoCambio;
       private double volumeCombustivel;
       private string tipoCombustivel;

        public global::System.String Modelo { get => modelo; set => modelo = value; }
        public global::System.String Cor { get => cor; set => cor = value; }
        public global::System.Int32 Ano { get => ano; set => ano = value; }
        public global::System.String Marca { get => marca; set => marca = value; }
        public global::System.Int64 Chassi { get => chassi; set => chassi = value; }
        public global::System.Double VelocidadeMaxima { get => velocidadeMaxima; set => velocidadeMaxima = value; }
        public global::System.Double VelocidadeAtual { get => velocidadeAtual; set => velocidadeAtual = value; }
        public global::System.Int32 NumPortas { get => numPortas; set => numPortas = value; }
        public global::System.Int32 NumMarchas { get => numMarchas; set => numMarchas = value; }
        public global::System.Int32 MarchaAtual { get => marchaAtual; set => marchaAtual = value; }
        public global::System.String TipoCambio { get => tipoCambio; set => tipoCambio = value; }
        public global::System.Double VolumeCombustivel { get => volumeCombustivel; set => volumeCombustivel = value; }
        public global::System.String TipoCombustivel { get => tipoCombustivel; set => tipoCombustivel = value; }

        prublic Carro(string modelo,string cor, string marca,long chassi,int ano)
        {
            this.Modelo = modelo;
            this.Cor = cor;
            this.Marca = marca;
            this.Chassi = chassi;
            this.Ano = ano;
        }
        //metodos
                public string Getmodelo()
        {
            return this.Modelo;
        }
        public void Setmodelo(string modelo)
        {
            this.modelo = modelo;
        }

        public void acelerar()
        {
            velocidadeAtual++;
        }
        public void frear()
        {
            if(velocidadeAtual != 0)
            {
                velocidadeAtual = 0;
            }

          //  velocidadeAtual = velocidadeAtual - velocidadeAtual;
        }
        public void aumentarMarcha(int valor)
        {
            if(valor <= numMarchas)
            {
                marchaAtual = valor;
            }
        }

        public void reduzirMarcha()
        {
            if (marchaAtual > 0 )
            {
                marchaAtual--;
            }

        }

        public void marchaRe()
        {
            if (velocidadeAtual == 0)
            {
                marchaAtual = -1;
            }
        }

        public double consumoMedio(double kmRodados,double precoL)
        {
            return precoL / kmRodados;
        }

    }
}
