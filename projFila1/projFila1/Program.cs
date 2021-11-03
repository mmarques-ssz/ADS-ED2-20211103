using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projFila1
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> filaNum = new Queue<int>();

            filaNum.Enqueue(6);
            filaNum.Enqueue(12);
            filaNum.Enqueue(9);
            filaNum.Enqueue(5);
            mostraFila(filaNum);

            Console.WriteLine("Desenfileirado: {0}", filaNum.Dequeue());
            
            mostraFila(filaNum);

            Console.WriteLine("Primeiro da fila: {0}", filaNum.Peek());
            Console.WriteLine("Primeiro da fila: {0}", filaNum.First());
            Console.WriteLine("Último da fila: {0}", filaNum.Last());
            Console.WriteLine("2º elemento: {0}", filaNum.ElementAt(1));

            mostraFila(filaNum);
        }

        static void mostraFila(Queue<int> fn)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Qtde de elementos: {0}", fn.Count);
            foreach (int num in fn)
                Console.WriteLine("Elemento: {0}", num);
            Console.WriteLine("----------------------");
        }


    }
}
