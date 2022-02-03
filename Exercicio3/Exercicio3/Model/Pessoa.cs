using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3.Model
{
    class Pessoa
    {
        private string nome;
        private string cargo;

        public string Nome { get => nome; set => nome = value; }
        public string Cargo{ get => cargo; set => cargo = value; }
    }
}
