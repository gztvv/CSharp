using Pagamentos;
using System;
using System.Globalization;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();

            Console.WriteLine("Digite o nome");
            string nome = Console.ReadLine();

            pessoa.setNome(nome);
            Console.WriteLine(pessoa.Nome);
        }
    }
}