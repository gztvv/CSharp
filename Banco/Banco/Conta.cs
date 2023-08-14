using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Conta
{
    public int IdConta { get; private set; }
    public string? Nome { get; set; }
    public double Saldo { get; private set; }

    public Conta() { }
    public Conta(int id, string nome, double saldo)
    {
        IdConta = id;
        Nome = nome;
        Saldo = saldo;
    }

    public void ZerarConta()
    {

        Saldo = 0;
    }
    public void Deposito(double deposito)
    {   
        Saldo += deposito;

    }
    public void Saque(double saque)
    {
        double taxa = 5;
        Saldo -= (saque + taxa);
    }

    public override string ToString()
    {
        return $"Conta {IdConta}, Titular: {Nome}, Saldo: {Saldo}";
    }
}