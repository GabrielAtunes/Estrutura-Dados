using System;
using API;

namespace API
{
    public class Program
    {
        static void Main(string[] args)
        {
            string opcao;

            Vetores vetores = new Vetores();
            Matrizes matrizes = new Matrizes();
            Lista lista = new Lista();
            Fila fila =  new Fila ();
            Pilha pilha = new Pilha();
            AlgoritmosBusca busca = new AlgoritmosBusca();

            do
            {
                Console.WriteLine("\n=== MENU PRINCIPAL ===");
                Console.WriteLine("1 - Vetores");
                Console.WriteLine("2 - Matrizes");
                Console.WriteLine("3 - Lista");
                Console.WriteLine("4 - Fila");
                Console.WriteLine("5 - Pilha");
                Console.WriteLine("6 - Algoritmos de Pesquisa");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        vetores.Menu();
                        break;
                    case "2":
                        matrizes.Menu();
                        break;
                    case "3":
                        lista.Menu();
                        break;
                    case "4":
                        fila.Menu();
                        break;
                    case "5":
                        pilha.Menu();
                        break;
                    case "6":
                        busca.Menu();
                        break;
                    case "0":
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

            } while (opcao != "0");
        }
    }
}
