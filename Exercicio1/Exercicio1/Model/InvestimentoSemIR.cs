using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1.Model
{
    class InvestimentoSemIR : Investimento
    {
        public override double calcularLucro(int meses)
        {
            double lucroSemIR;  
            if (ValorInicial < 1000)
            {
                Console.WriteLine("O valor inicial não pode ser menor que 1.000,00");
                return 0;
                
            }
            return lucroSemIR = (ValorInicial * Math.Pow((1 + JurosMensal / 100), meses)) - ValorInicial;
        }

    }
}
