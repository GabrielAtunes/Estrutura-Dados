using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz5
{
    class Program
    {
        static void Main(string[] args)
        {
            int l, c;
            string[] valores;
            int[,] vetA, vetB, vetC;

            valores = Console.ReadLine().Split(' ');

            l = Convert.ToInt32(valores[0]);
            c = Convert.ToInt32(valores[1]);

            vetA = new int[l, c];
            vetB = new int[l, c];
            vetC = new int[l, c];


            for (int lin = 0; lin < l; lin++)
            {
                valores = Console.ReadLine().Split(' ');

                for (int col = 0; col < c; col++)
                {
                    vetA[lin, col] = Convert.ToInt32(valores[col]);                    
                }
            }

            for (int lin = 0; lin < l; lin++)
            {
                valores = Console.ReadLine().Split(' ');

                for (int col = 0; col < c; col++)
                {
                    vetB[lin, col] = Convert.ToInt32(valores[col]);
                }
            }

            for (int lin = 0; lin < l; lin++)
            {
                for (int col = 0; col < c; col++)
                {
                    vetC[lin, col] = vetA[lin, col] + vetB[lin, col];
                    Console.Write(vetC[lin, col] + " ");
                }
                Console.Write("\n");
            }

            Console.ReadKey();

        }
    }
}
