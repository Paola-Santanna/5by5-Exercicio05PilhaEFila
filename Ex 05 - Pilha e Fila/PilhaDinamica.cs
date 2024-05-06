using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_05___Pilha_e_Fila
{
    internal class PilhaDinamica
    {
        Numero aux;
        Numero topo;
        Numero anterior;

        public PilhaDinamica()
        {
            this.aux = null;
            this.anterior = null;
            this.topo = null;
        }

        public bool PilhaVazia()
        {
            if (topo == null)
                return true;
            else
                return false;
        }

        public void AdicionarNumPilha(Numero numero)
        {
            if (PilhaVazia() == true)
            {
                this.topo = this.aux = numero;
            }
            else
            {
                this.anterior = this.topo;
                this.aux = numero;
                this.topo = this.aux;
            }
        }

        public void MostrarNumPilha()
        {
            Numero aux = this.topo;
            Console.WriteLine("Números da Pilha:");
            do
            {
                Console.WriteLine(this.aux.ToString());
                this.aux = this.anterior;
            } while (aux != null);
        }

    }
}
