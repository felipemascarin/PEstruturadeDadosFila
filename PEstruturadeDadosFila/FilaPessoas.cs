using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEstruturadeDadosFila
{
    internal class FilaPessoas
    {
        public Pessoa HEAD { get; set; }
        public Pessoa TAIL { get; set; }
        public FilaPessoas()
        {
            HEAD = null;
            TAIL = null;
        }
        public void Push(Pessoa aux)
        {
            if (Vazia())
            {
                HEAD = TAIL = aux;
            }
            else
            {
                TAIL.Proximo = aux;
                TAIL = aux;
            }
            Console.WriteLine("Inserido com Sucesso!!!");
            Console.ReadKey();
        }
        public void Pop()
        {
            if (Vazia())
            {
                Console.WriteLine("Fila vazia!!");
            }
            else
            {
                HEAD = HEAD.Proximo;
                if (HEAD == TAIL)
                {
                    TAIL = null;
                    Console.WriteLine("Elemento Removido!");
                }
            }
            Console.ReadKey();
        }
        public void Print()
        {
            if (Vazia())
            {
                Console.WriteLine("Fila Vazia!!");
            }
            else
            {
                Pessoa aux = HEAD;
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.Proximo;
                } while (aux != null);
                Console.WriteLine("Fim da Impressao");
            }
            Console.ReadKey();
        }
        public bool Vazia()
        {
            if ((HEAD == null) && (TAIL == null))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}








