using ConvesorDolar;
using System;
using System.Globalization;

namespace Conversor
{
    class Program
    {
        static void Main(string[] args) {

            DolarReal conv = new DolarReal();

            Console.WriteLine("Digite a cotacao do dolar: ");
            conv.Cotacao = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite quantos dolares você vai comprar: ");
            conv.Valor = double.Parse(Console.ReadLine());

            double resultado = conv.valorTotal(conv.Cotacao, conv.Valor);

            Console.WriteLine($"Valor a ser pago em reais: {resultado}");


        }
    }
}