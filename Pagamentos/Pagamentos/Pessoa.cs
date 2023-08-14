using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagamentos
{
    class Pessoa
    {
        public int Id 
        {  get; private set; }
        public string? Nome { get;  private set; }


        public void setNome(string nome)
        {
            Nome = nome + "  Souza" ;
        }

    }
}
