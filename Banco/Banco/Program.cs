using System;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Globalization;



class Program
{
    static void Main(string[] args)
    {

        double deposito,saque;
        string validar = "s";
        
        Console.WriteLine("Entre com o numero da conta: ");
        int id = int.Parse(Console.ReadLine());

        Console.WriteLine("Entre como o nome do titular da conta:");
        string  nome = Console.ReadLine();

        Console.WriteLine("Haverá deposito inicial? (s/n)");
        string res = (Console.ReadLine());

        if (res == validar)
        {
            Console.WriteLine("Entre como valor: ");
            deposito = double.Parse(Console.ReadLine()); 
        }
        else
        {
            deposito = 0;
        }

        Conta conta = new Conta(id,nome,deposito);

        
        Console.WriteLine(conta.ToString());

        Console.WriteLine("Entre com um valor para deposito");
        deposito = double.Parse((Console.ReadLine()));

        conta.Deposito(deposito);

        
        Console.WriteLine("Dados da conta atulizado: ");
        Console.WriteLine(conta.ToString());

       

        Console.WriteLine("Entre com um valor para saque: ");
        saque = double.Parse((Console.ReadLine()));

        conta.Saque(saque);

        
        Console.WriteLine("Dados da conta atulizado: ");
        Console.WriteLine(conta.ToString());




    }
}