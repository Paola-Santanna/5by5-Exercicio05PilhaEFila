using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_05___Pilha_e_Fila
{
    internal class Numero
    {
        int numero;
        Numero anterior;
        Numero proximo;

        public Numero(int numero)
        {
            this.numero = numero;
            this.anterior = null;
            this.proximo = null;
        }
        
        public void AdicionarNum()
        {
            Console.Write("Insira um número: ");
        }

        public void AtribuirNumAnterior (Numero anterior)
        {
            this.anterior = anterior;
        }

        public void AtribuirNumProximo (Numero proximo)
        {
            this.proximo = proximo;
        }

        public override string? ToString()
        {
            return $"{this.numero}";
        }
    }
}
