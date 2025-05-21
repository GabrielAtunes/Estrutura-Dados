using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetor9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                 lucro< 10%
                 10% ≤ lucro ≤ 20%
                 lucro> 20%
             */
            int n, contDez, contVinte, contMaior;
            float compra, venda, tCompra, tVenda;
            string[] valores;

            tCompra = 0; tVenda = 0; contDez = 0; contVinte = 0; contMaior = 0;

            Console.WriteLine("Digite a quantidade de itens: ");
            n = int.Parse(Console.ReadLine());

            valores = new string[n];
            

            for (int i = 0; i < n; i++)
            {
                valores = Console.ReadLine().Split(' ');

                compra = float.Parse(valores[1]);
                venda = float.Parse(valores[2]);

                tCompra += compra;
                tVenda += venda;

                if(((venda - compra) / compra) < 0.1)
                {
                    contDez++;
                }else if (((venda - compra) / compra) <= 0.2)
                {
                    contVinte++;
                }
                else
                {
                    contMaior++;
                }
            }
            
            Console.WriteLine($"Lucro abaixo de 10: {contDez}");
            Console.WriteLine($"Lucro entre 10% e 20%: {contVinte}");
            Console.WriteLine($"Lucro maior que 20%: {contMaior}");
            Console.WriteLine($"Total de compra: {tCompra:F2}");
            Console.WriteLine($"Total de venda: {tVenda:F2}");
            Console.WriteLine($"Lucro total: {(tVenda - tCompra):F2}");
            Console.ReadKey();

        }
    }
}
