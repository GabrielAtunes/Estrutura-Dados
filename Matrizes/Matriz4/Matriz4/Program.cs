using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, soma = 0;
            string[] valores;
            int[,] mat;

            n = Convert.ToInt32(Console.ReadLine());
            
            valores = new string[n];
            mat = new int[n, n];


            for (int lin = 0; lin < n; lin++)
            {
                valores = Console.ReadLine().Split(' ');

                for (int col = 0; col < n; col++)
                {
                    mat[lin, col] = int.Parse(valores[col]);
                }
            }


            for (int lin = 0; lin < n; lin++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (col > lin)
                    {
                        soma += mat[lin, col];
                    }
                }
            }

            Console.WriteLine(soma);
            Console.ReadKey();
        }
    }
}
