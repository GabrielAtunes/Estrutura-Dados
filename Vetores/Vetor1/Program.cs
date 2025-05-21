using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Vetor1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, nMaior;
            float[] lista;
            string[] valores;
            float maior;

            maior = 0;
            nMaior = 0;

            Console.WriteLine("Digite a quantidade de números a serem lidos: ");
            n = int.Parse(Console.ReadLine());

            lista = new float[n];
            valores = new string[n];

            valores = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                lista[i] = float.Parse(valores[i]);

                if (lista[i] > maior)
                {
                    nMaior = i;
                    maior = lista[i];
                }

            }

            Console.Write(maior + "\n");
            Console.Write(nMaior);
            Console.ReadKey();
        }
    }
}
