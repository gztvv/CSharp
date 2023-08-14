using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvesorDolar
{
    class DolarReal
    {
        private double cotacao;
        private double valor;
        public static double Iof = 0.06;

        public double Valor { get => valor; set => valor = value; }
        public double Cotacao { get => cotacao; set => cotacao = value; }
        public double  valorTotal (double cotacao, double valor)
        {
            double totalsemiof = (cotacao * valor);
            double total = totalsemiof + (totalsemiof * Iof);
            return total;
        }
    }
}
