using System;
using System.Globalization;


class Program
{
    static void Main(string[] args)
    {
        List<Funcionarios> listaFuncionarios = new List<Funcionarios>();



        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine($"Digite o nome do {i + 1}funcinario");
            string nome = Console.ReadLine();

            Console.WriteLine($"Digite o salario do {i + 1} funcionario ");
            double salario = double.Parse(Console.ReadLine());

            Funcionarios funcionario = new Funcionarios (nome,salario);

            listaFuncionarios.Add(funcionario);           

        }

        double mediasalarios = Media(listaFuncionarios[0].salario, listaFuncionarios[1].salario);

        Console.WriteLine(mediasalarios);
    }

    static double Media(double a , double b) {
        return (a + b)/ 2 ;
    
    }
}