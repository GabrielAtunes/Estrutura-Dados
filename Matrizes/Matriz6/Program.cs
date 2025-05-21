using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, imprimirLinha, imprimirColuna;
            float[,] vetA;
            string[] valores;
            float soma = 0;

            n = Convert.ToInt32(Console.ReadLine());

            vetA = new float[n, n];

            
            /*Lê os valores*/
            for (int lin = 0; lin < n; lin++)
            {
                valores = Console.ReadLine().Split(' ');

                for (int col = 0; col < n; col++)
                {
                    vetA[lin, col] = float.Parse(valores[col]); 
                }
            }

            /*Soma os valores*/
            for (int lin= 0; lin < n; lin++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (vetA[lin, col] > 0.0)
                    {
                        soma += vetA[lin, col];
                    }
                }
            }

            Console.WriteLine("SOMA DOS POSITIVOS: " + soma);

            /*Seleciona e imprime a linha*/
            imprimirLinha = Convert.ToInt32(Console.ReadLine());
            Console.Write("LINHA ESCOLHIDA: ");
            for (int col = 0; col < n; col++)
            {
                Console.Write(vetA[imprimirLinha, col] + " ");
            }
            Console.WriteLine();

            /*Seleciona e imprime a coluna*/
            imprimirColuna = int.Parse(Console.ReadLine());
            Console.Write("COLUNA ESCOLHIDA: ");
            for (int lin = 0; lin < n; lin++)
            {
                Console.Write(vetA[lin, imprimirColuna] + " ");
            }
            Console.WriteLine();

            /*Imprime a diagonal principal*/
            Console.Write("DIAGONAL PRINCIPAL: ");
            for (int lin = 0; lin < n; lin++)
            {
                for (int col = lin; col <= lin; col++)
                {
                    Console.Write(vetA[lin, col] + " ");
                }
            }
            Console.WriteLine();

            /*Eleva os números negativos ao quadrado*/
            Console.WriteLine("MATRIZ ALTERADA:");
            for (int lin = 0; lin < n; lin++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (vetA[lin, col] < 0.0)
                    {
                        vetA[lin, col] = vetA[lin, col] * vetA[lin, col];
                    }

                    Console.Write(vetA[lin, col] + " ");
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
