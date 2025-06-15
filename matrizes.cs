namespace API
{
    public class Matrizes
    {
        private int[,] matriz = new int[3, 3];

        public void Menu()
        {
            string opc;
            do
            {
                Console.WriteLine("\n[ MATRIZ ]");
                Console.WriteLine("1 - Inserir");
                Console.WriteLine("2 - Remover");
                Console.WriteLine("3 - Exibir");
                Console.WriteLine("4 - Consultar");
                Console.WriteLine("0 - Voltar");
                opc = Console.ReadLine();

                switch (opc)
                {
                    case "1": Inserir(); break;
                    case "2": Remover(); break;
                    case "3": Exibir(); break;
                    case "4": Consultar(); break;
                }

            } while (opc != "0");
        }

        private void Inserir()
        {
            Console.Write("Linha (0-2): ");
            int i = int.Parse(Console.ReadLine());
            Console.Write("Coluna (0-2): ");
            int j = int.Parse(Console.ReadLine());
            Console.Write("Valor: ");
            matriz[i, j] = int.Parse(Console.ReadLine());
        }

        private void Remover()
        {
            Console.Write("Linha (0-2): ");
            int i = int.Parse(Console.ReadLine());
            Console.Write("Coluna (0-2): ");
            int j = int.Parse(Console.ReadLine());
            matriz[i, j] = 0;
            Console.WriteLine("Elemento removido.");
        }

        private void Exibir()
        {
            Console.WriteLine("Matriz:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write($"{matriz[i, j]} ");
                Console.WriteLine();
            }
        }

        private void Consultar()
        {
            Console.Write("Valor a buscar: ");
            int n = int.Parse(Console.ReadLine());
            bool encontrado = false;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (matriz[i, j] == n)
                    {
                        Console.WriteLine($"Encontrado na posição [{i},{j}]");
                        encontrado = true;
                    }
            if (!encontrado)
                Console.WriteLine("Valor não encontrado.");
        }
    }
}
