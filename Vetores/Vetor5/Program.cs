using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetor5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, soma, nPar;
            string[] lista;
            float media;
            soma = 0; nPar = 0;

            Console.WriteLine("Digite a quantide de valores a serem lidos: ");

            n = int.Parse(Console.ReadLine());

            lista = new string[n];

            Console.WriteLine("Digite os valores: ");
            lista = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                if (int.Parse(lista[i]) % 2 == 0)
                {
                    soma += int.Parse(lista[i]);
                    nPar++;
                }
            }

            media = soma / nPar;

            Console.WriteLine(media);
            Console.ReadKey();
        }
    }
}
