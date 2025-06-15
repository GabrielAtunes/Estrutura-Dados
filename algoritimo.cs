namespace API
{
    public class AlgoritmosBusca
    {
        private List<int> dados = new List<int>();

        public void Menu()
        {
            string opc;
            do
            {
                Console.WriteLine("\n[ ALGORITMOS DE BUSCA ]");
                Console.WriteLine("1 - Inserir elementos");
                Console.WriteLine("2 - Exibir elementos");
                Console.WriteLine("3 - Busca Linear");
                Console.WriteLine("4 - Busca Binária");
                Console.WriteLine("0 - Voltar");
                opc = Console.ReadLine();

                switch (opc)
                {
                    case "1": Inserir(); break;
                    case "2": Exibir(); break;
                    case "3": BuscaLinear(); break;
                    case "4": BuscaBinaria(); break;
                }

            } while (opc != "0");
        }

        private void Inserir()
        {
            Console.Write("Valor a adicionar: ");
            dados.Add(int.Parse(Console.ReadLine()));
        }

        private void Exibir()
        {
            Console.WriteLine("Dados:");
            dados.Sort();
            foreach (int n in dados)
                Console.WriteLine(n);
        }

        private void BuscaLinear()
        {
            Console.Write("Valor a buscar: ");
            int alvo = int.Parse(Console.ReadLine());
            bool achou = dados.Contains(alvo);
            Console.WriteLine(achou ? "Encontrado (busca linear)." : "Não encontrado.");
        }

        private void BuscaBinaria()
        {
            dados.Sort();
            Console.Write("Valor a buscar: ");
            int alvo = int.Parse(Console.ReadLine());
            int pos = dados.BinarySearch(alvo);
            if (pos >= 0)
                Console.WriteLine($"Encontrado na posição {pos} (busca binária).");
            else
                Console.WriteLine("Não encontrado.");
        }
    }
}
