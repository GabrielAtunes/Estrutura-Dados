using System;

namespace Matriz3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o tamanho da matriz (n): ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];
            int[] maiores = new int[n];

            // Lê os valores da matriz
            Console.WriteLine($"Digite os {n}x{n} valores da matriz, separados por espaço:");
            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(valores[j]);
                }
            }

            // Encontra o maior valor de cada linha
            for (int i = 0; i < n; i++)
            {
                maiores[i] = mat[i, 0]; // Inicializa com o primeiro elemento da linha
                for (int j = 1; j < n; j++)
                {
                    if (mat[i, j] > maiores[i])
                    {
                        maiores[i] = mat[i, j];
                    }
                }
            }

            // Exibe os maiores valores de cada linha
            Console.WriteLine("\nMaiores valores de cada linha:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Linha {i + 1}: {maiores[i]}");
            }

            Console.ReadKey();
        }
    }
}