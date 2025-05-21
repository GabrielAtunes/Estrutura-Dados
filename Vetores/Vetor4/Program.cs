using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetor4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            string[] lista;
            float soma, media;

            Console.WriteLine("Digite a quantidade de números a serem lidos: ");
            n = int.Parse(Console.ReadLine());

            soma = 0f;
            lista = new string[n];

            lista = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                soma = soma + (float.Parse(lista[i]));
                //Console.WriteLine("Soma: " + soma + " | lista " + i + " = " + lista[i]);
            }

            media = (soma / n);

            Console.WriteLine(media);

            for (int i = 0; i < n; i++)
            {
                if (float.Parse(lista[i]) < media)
                {
                    Console.WriteLine(float.Parse(lista[i]) + " ");
                }
            }

            Console.ReadKey();
        }
    }
}
