using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagamentos
{
    class Conta
    {
        private int _saldo;

        public Conta(int saldo)
        {
            this._saldo = saldo;
        }

        public int saldo  // Propriedade = Conta.saldo
            // mais indicado nesse caso, utilizar uma propriedade para retornar o saldo já que não vai ser feita nenhuma operacao no retorno do saldo
        {
            get 
            { 
                return _saldo; 
            } 
        }

        public int getSaldo() { return _saldo;} // Metodo ()
        // seria a melhor opcao caso houvesse algum calculo realizado antes da retorno do saldo, por exemplo se fosse o retorno de um saldo com acressimo de juros ou algo do tipo
    }
}
