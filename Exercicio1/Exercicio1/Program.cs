using Exercicio1.Model;
using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao, meses;
            Console.WriteLine("Digite 1 para Investir com IR e 2 para Inestir sem IR: ");
            opcao = Convert.ToInt32(Console.ReadLine());

            if (opcao == 1)
            {
                InvestimentoComIR investComIR = new InvestimentoComIR();
                Console.WriteLine("Insira o valor inicial do seu investimento: ");
                investComIR.ValorInicial = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Insira a porcentagem dos juros ao mês: ");
                investComIR.JurosMensal = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Informe qual o período que deseja investir: ");
                meses = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(investComIR.calcularLucro(meses));
            }
            else if (opcao == 2)
            {
                InvestimentoSemIR investSemIR = new InvestimentoSemIR();
                Console.WriteLine("Insira o valor inicial do seu investimento: ");
                investSemIR.ValorInicial = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Insira a porcentagem dos juros ao mês: ");
                investSemIR.JurosMensal = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Informe qual o período que deseja investir: ");
                meses = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(investSemIR.calcularLucro(meses));

            }
            else
            {
                Console.WriteLine("Por gentileza, informa uma opção válida!");
            }

        }
    }
}
