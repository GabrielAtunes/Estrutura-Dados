using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetor3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int[] vetA, vetB, vetC;
            string[] temp;

            Console.WriteLine("Digite a quantidade de valores a serem lidos");
            n = int.Parse(Console.ReadLine());

            vetA = new int[n];
            vetB = new int[n];
            vetC = new int[n];
            temp = new string[n];

            Console.WriteLine("Digite os valores do vetor A");
            temp = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                vetA[i] = int.Parse(temp[i]);
            }

            Console.WriteLine("Digite os valores do vetor B");
            temp = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                vetB[i] = int.Parse(temp[i]);
            }

            for (int i = 0; i < n; i++)
            {
                vetC[i] = (vetA[i] + vetB[i]);
                Console.Write(vetC[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
