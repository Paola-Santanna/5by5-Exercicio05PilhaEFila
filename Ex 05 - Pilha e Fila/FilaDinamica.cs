using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_05___Pilha_e_Fila
{
    internal class FilaDinamica
    {
        Numero head;
        Numero tail;

        public FilaDinamica()
        {
            this.head = null;
            this.tail = null;
        }

        public bool FilaVazia()
        {
            if (tail == null)
                return true;
            else
                return false;
        }

        public void ReceberNumFila(Numero numero)
        {
            Numero aux;

            if (FilaVazia() == true)
            {
                aux = numero;
                this.head = this.tail;
                this.tail = aux;
            }
            else
            {
                AdicionarNumFila(numero);
            }
        }

        public void AdicionarNumFila(Numero numero)
        {
            Numero aux = numero;
            this.head = this.tail;
            this.tail = aux;
        }

        public void ImprimirNumFila()
        {
            Numero aux;

            Console.WriteLine("Números da fila: ");
            do
            {
                aux = this.head;

                Console.Write(aux.ToString() + " ");

                this.head = this.tail;
                this.tail = aux;
            } while (this.head == null);

        }
    }
}
