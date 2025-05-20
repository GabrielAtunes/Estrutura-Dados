using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetor_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, qtdPares = 0;
            int[] vetor;

            n = int.Parse(Console.ReadLine());

            vetor = new int[n];

            string[] valores = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                vetor[i] = int.Parse(valores[i]);
            }

            //Exibir os pares
            for (int i = 0; i < n; i++)
            {
                if (vetor[i] % 2 == 0)
                {
                    Console.Write(vetor[i] + " ");
                    qtdPares++;
                }
            }
            Console.WriteLine();
            Console.WriteLine(qtdPares);
            Console.ReadKey();
        }
    }
}
