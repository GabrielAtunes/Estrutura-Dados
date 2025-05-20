using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetor7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] alunos, resultado, valores;
            float[] notas;
            int n, index;

            Console.WriteLine("Digite a quantidade de alunos: ");
            n = int.Parse(Console.ReadLine());

            alunos = new string[n];
            valores = new string[n];
            resultado = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite o nome do aluno, seguido pelas notas do 1º e 2º semestre");
                valores = Console.ReadLine().Split(' ');

                alunos[i] = valores[0];

                if (((float.Parse(valores[1]) + float.Parse(valores[2])) / 2) >= 6)
                {
                    resultado[i] = "Aprovado";
                    //Console.WriteLine(alunos[i]);
                }
                else
                {
                    resultado[i] = "Reprovado";
                }
            }

            index = 0;

            Console.WriteLine("Alunos aprovados");
            foreach (var item in resultado)
            {
                if(item == "Aprovado")
                {
                    Console.WriteLine(alunos[index]);
                }

                index++;
            }

            Console.ReadKey();
        }
    }
}
