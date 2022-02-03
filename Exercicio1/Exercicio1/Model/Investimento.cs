using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1.Model
{
    class Investimento
    {
        private double valorInicial;
        private double jurosMensais;

        public double ValorInicial{ get => valorInicial; set => valorInicial = value; }
        public double JurosMensal { get => jurosMensais; set => jurosMensais = value; }

        public virtual double calcularLucro(int meses)
        {
            double lucro = 0.0;
            if (ValorInicial < 1000)
            {
                Console.WriteLine("O valor inicial não pode ser menor que 1.000,00");
                return 0;

            }
            
            return lucro = (valorInicial * Math.Pow((1 + jurosMensais / 100), meses)) - valorInicial;
        }

       

       
    }
}
