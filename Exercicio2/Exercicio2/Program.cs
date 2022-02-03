using System;
using System.Collections.Generic;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
            int maiorValor = 0;
            int menorValor = 0;
            int qtdAcima10 = 0, qtdAcima50 = 0;
            double media = 0.0;
            string retornoAcima10 = "", retornoAcima50 = "";
            


            List<int> listaNum = new List<int>();
            List<int> listaNumAcima10 = new List<int>();
            List<int> listaNumAcima50 = new List<int>();

            Console.WriteLine("Por gentileza, insira 10 números de sua preferência");
            for (int i = 0; i < 5; i++)
            {
                int numero = Convert.ToInt32(Console.ReadLine());
                listaNum.Add(numero);
            }

            // Percorrendo a lista de números
            foreach (int num in listaNum)
            {
                // Verificando qual o maior e menor valor
                if (num > maiorValor)
                {
                    maiorValor = num;
                }
                else
                {
                    //Falta implementar lógica de menor valor
                    menorValor = num; 
                              
                }

                // Verificando quantos e quais são os maiores de 10
                if (num > 10)
                {
                    qtdAcima10 += 1;
                    listaNumAcima10.Add(num);
                }

                //Verificando quantos e quais são os maiores de  50
                if (num > 50)
                {
                    qtdAcima50 += 1;
                    listaNumAcima50.Add(num);
                }

                soma += num;
            }
            //Realizando a média dos números inseridos
            media = soma / listaNum.Count;

            foreach (int num in listaNumAcima10)
            {
                retornoAcima10 += num.ToString() + "\n";
            }
           
            foreach (int num in listaNumAcima50)
            {
                retornoAcima50 += num.ToString() + "\n";  
            }

            Console.WriteLine("O maior número é: " + maiorValor.ToString());
            Console.WriteLine("O menor número é: " + menorValor.ToString());
            Console.WriteLine("A média dos números é: " + media.ToString());
            Console.WriteLine("A quantidade de números maiores que 10 é: " + qtdAcima10.ToString() + " tais quais: " + retornoAcima10);
            Console.WriteLine("A quantidade de números maiores que 50 é: " + qtdAcima50.ToString() + " tais quais: " + retornoAcima50);





        }
    }
}
