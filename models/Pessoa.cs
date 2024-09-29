using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosFundamentos.models
{
    public class Pessoa
    {
        public  string? Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, me chamo {Nome}" +
             $" e tenho {Idade} anos.");

             //Abaixo esta a quebra de linha (\r\n)
             //Console.WriteLine($"Olá, me chamo {Nome}\r\n e tenho {Idade} anos.");
            
        }
    }
}