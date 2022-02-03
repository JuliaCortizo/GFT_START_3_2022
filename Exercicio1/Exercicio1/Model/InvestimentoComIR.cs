using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1.Model
{
    class InvestimentoComIR:Investimento
    {
        public override double calcularLucro(int meses)
        {
            double lucroComIR = 0.0;
            double desconto = 0.0;
            //Verificando valor mínimo
            if (ValorInicial < 1000)
            {
                Console.WriteLine("O valor inicial não pode ser menor que 1.000,00");
                return 0;

            }

            if (meses < 6)
            {
                desconto = 22.5;
            }else if (meses >= 6 && meses < 12){
                desconto = 20.0;
            }
            else if (meses >= 12 && meses < 24)
            {
                desconto = 17.5;
            }
            else
            {
                desconto = 15.0;
            }

            return lucroComIR = ((ValorInicial * Math.Pow((1 + JurosMensal), meses)) - ValorInicial) - desconto;

            
        }
    }
}
