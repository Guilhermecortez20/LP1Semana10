using System;
using System.Collections.Generic;

namespace IntCollections
{
    class Program
    {
        static void Main()
        {
            // Dados a inserir
            int[] valores = { 1, 10, -30, 10, -5 };

            // Declaração das coleções
            List<int> lista = new List<int>();
            Stack<int> pilha = new Stack<int>();
            Queue<int> fila = new Queue<int>();
            HashSet<int> conjunto = new HashSet<int>();

            // Inserção de dados
            foreach (int valor in valores)
            {
                lista.Add(valor);
                pilha.Push(valor);
                fila.Enqueue(valor);
                conjunto.Add(valor);
            }

            // Impressão dos dados
            Console.WriteLine("List: " + string.Join(", ", lista));
            Console.WriteLine("Stack: " + string.Join(", ", pilha));
            Console.WriteLine("Queue: " + string.Join(", ", fila));
            Console.WriteLine("HashSet: " + string.Join(", ", conjunto));
        }
    }
}

