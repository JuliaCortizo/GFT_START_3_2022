using Exercicio3.Model;
using System;
using System.Collections.Generic;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            string cargo;
            List<Pessoa> listaPessoa = new List<Pessoa>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Informe o nome da {i}ª pessoa: ");
                listaPessoa[i].Nome = Console.ReadLine();
                Console.WriteLine($"Informe o cargo da {i}ª pessoa: (Starter, Junior ou Senior)");
                cargo = Console.ReadLine();

                if (cargo.ToLower() != "starter" || cargo.ToLower() != "junior" || cargo.ToLower() != "senior")
                {
                    listaPessoa[i].Cargo = "Senior";

                }
                else
                {
                    listaPessoa[i].Cargo = cargo;
                }
                
            }
        }
    }
}
