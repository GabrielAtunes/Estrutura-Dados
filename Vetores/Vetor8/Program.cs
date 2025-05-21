using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetor8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores, sexo;
            int n, contMulheres, contHomens;
            float[] altura;
            float maior, menor, alturaMulheres;

            contHomens = 0; contMulheres = 0;
            alturaMulheres = 0f;
            menor = 0f; maior = 0f;

            Console.WriteLine("Digite a quantidade de pessoas: ");
            n = int.Parse(Console.ReadLine());
            valores = new string[n];
            sexo = new string[n];
            altura = new float[n];

            for (int i = 0; i < n; i++)
            {
                valores = Console.ReadLine().Split(' ');
                altura[i] = float.Parse(valores[0]);
                sexo[i] = valores[1];

                if (sexo[i] == "M")
                {
                    contHomens = contHomens + 1;
                }else if (sexo[i] == "F")
                {
                    contMulheres++;
                    alturaMulheres += altura[i];
                }
                else
                {
                    Console.WriteLine(sexo[i]);
                }

            }

            for (int i = 0; i < n; i++)
            {

                if (i == 0)
                {
                    menor = altura[i];
                    menor = altura[i];
                }
                if (altura[i] > maior){
                    maior = altura[i];
                }

                if (altura[i] < menor)
                {
                    menor = altura[i];
                }
            }

            Console.WriteLine($"Menor altura: {menor:F2}");
            Console.WriteLine($"Maior altura: {maior:F2}");
            Console.WriteLine($"Média das alturas das mulhres: {(alturaMulheres / contMulheres):F2}");
            Console.WriteLine($"Número de homens: {contHomens}");
            Console.ReadKey();

        }
    }
}
