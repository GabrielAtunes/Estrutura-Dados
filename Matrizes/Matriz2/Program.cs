using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores;
            int m, n; int[] soma;
            int[,] matriz;

            m = int.Parse(Console.ReadLine()); //Linha
            n = m; //Coluna

            soma = new int[n];

            matriz = new int[n, m];

            //Recebe os valores
            for (int lin = 0; lin < m; lin++)
            {
                valores = Console.ReadLine().Split(' ');

                for (int col = 0; col < n; col++)
                {
                    matriz[lin, col] = int.Parse(valores[col]);
                }
            }

            for (int lin = 0; lin < m; lin++)
            {
                for (int col = 0; col < n; col++)
                {
                    soma[lin] += matriz[lin, col]; 
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(soma[i]);
            }

        }
    }
}
