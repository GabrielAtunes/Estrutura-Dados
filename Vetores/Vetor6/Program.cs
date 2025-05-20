using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetor6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, maior, iMaior;
            int[] idades;
            string[] valores, nomes;

            maior = 0;
            iMaior = 0;

            Console.WriteLine("Digite a quantidade de valores a serem lidos");
            n = int.Parse(Console.ReadLine());

            idades = new int[n];
            valores = new string[n];
            nomes = new string[n];

            for (int i = 0; i < n; i++)
            {
                valores = Console.ReadLine().Split(' ');

                nomes[i] = valores[0];
                idades[i] = int.Parse(valores[1]);

            }

            for (int i = 0; i < n; i++)
            {
                if (idades[i] > maior)
                {
                    maior = idades[i];
                    iMaior = i;
                }
            }

            Console.WriteLine($"O aluno(a) mais velho(a) é {nomes[iMaior]}, ele(a) possui {maior} anos");
            Console.ReadKey();

        }
    }
}
