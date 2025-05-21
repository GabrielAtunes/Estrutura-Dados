using System.Numerics;

namespace API
{
    public class program
    {
        static void main()
        {
            List<char> lista = new List<char>();
            string OPCfila, OPCpilha;
            int opcao;
            int i=0;
            do
            {

                Console.WriteLine("\n O QUE DESEJA USAR ??");
                Console.WriteLine("0. SAIR DO SISTEMA");
                Console.WriteLine("1. VETORES");
                Console.WriteLine("2. MATRIZ");
                Console.WriteLine("3. LISTAS");
                Console.WriteLine("4. FILAS");
                Console.WriteLine("5. PILHAS");
                Console.WriteLine("6. ALGORITMO DE PESQUISAS");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {


                    case 1:
                        {
                            break;
                        }
                    case 2:
                        {
                            break;
                        }
                    case 3:
                        {
                            List<int> listas = new List<int>();
                            Console.WriteLine("\n O QUE DESEJA FAZER EM LISTAS ??");
                            Console.WriteLine("\n ADICIONAR (A) \n REMOVER ULTIMO(R) \n EXIBIR TODOS (E) \n BUSCAR/CONSULTAR(C)??\n SAIR(S)");
                            OPCfila = Console.ReadLine();
                            while (OPCfila != "S")
                            {
                                if (OPCfila == "A")
                                    listas.Add(int.Parse(Console.ReadLine()));

                                if (OPCfila == "R")
                                    i = 0;
                                    i = int.Parse(Console.ReadLine());
                                    listas.Remove(i);
                                if (OPCfila == "E")
                                    foreach (int numeros in listas)
                                    {
                                        Console.WriteLine(numeros);
                                    }

                                if (OPCfila == "C")
                                {
                                    Console.WriteLine("que numero deseja encontrar ");
                                    int numeros = int.Parse(Console.ReadLine());
                                    bool existe = listas.Contains(numeros);
                                    int indice = listas.IndexOf(numeros);
                                    Console.WriteLine($"{numeros} esta no indice {indice} da lista");
                                }
                                else
                                    break;
                            }
                            break;
                        }
                    case 4:
                        {

                            Queue<int> fila = new Queue<int>();
                            Console.WriteLine("\n O QUE DESEJA FAZER EM FILA ??");
                            Console.WriteLine("\n ADICIONAR (A) \n REMOVER PRIMEIRO(R) \n EXIBIR TODOS (E) \n BUSCAR/CONSULTAR(C)??\n SAIR(S)");
                            OPCfila = Console.ReadLine();
                            while (OPCfila != "S")
                            {
                                if (OPCfila == "A")
                                  i = int.Parse(Console.ReadLine());
                                fila.Enqueue(i);
                                if (OPCfila == "R")
                                    fila.Dequeue();
                                if (OPCfila == "E")
                                    foreach (int numeros in fila)
                                    {
                                        Console.WriteLine(numeros);
                                    }

                                if (OPCfila == "C")
                                {
                                    Console.WriteLine("que numero deseja encontrar ");
                                    int numeros = int.Parse(Console.ReadLine());
                                    bool existe = fila.Contains(numeros);

                                    Console.WriteLine($"{numeros}  existe na fila: {existe}");
                                }
                                else
                                    break;
                            }
                            break;
                        }
                    case 5:
                        {

                            Stack<int> pilha = new Stack<int>();
                            Console.WriteLine("\n O QUE DESEJA FAZER EM PILHA ??");
                            Console.WriteLine("\n ADICIONAR (A) \n REMOVER PRIMEIRO(R) \n EXIBIR TODOS (E) \n BUSCAR/CONSULTAR(C)??\n SAIR(S)");
                            OPCpilha = Console.ReadLine();
                            while (OPCpilha != "S")
                            {
                                if (OPCpilha == "A")
                                    i = int.Parse(Console.ReadLine());
                                pilha.Push(i);

                                if (OPCpilha == "R")
                                    pilha.Pop();
                                if (OPCpilha == "E")
                                    foreach (int numeros in pilha)
                                    {
                                        Console.WriteLine(numeros);
                                    }

                                if (OPCpilha == "C")
                                {
                                    Console.WriteLine("que numero deseja encontrar ");
                                    int numeros = int.Parse(Console.ReadLine());
                                    bool existe = pilha.Contains(numeros);

                                    Console.WriteLine($"{numeros} existe na pilha?: {existe}");
                                }
                                else
                                    break;
                            }
                            break;
                        }
                    case 6:

                        {
                            break;
                        }
                    default:
                        break;
                }
            
            } while (opcao != 0);
        }

    }
}



                        
