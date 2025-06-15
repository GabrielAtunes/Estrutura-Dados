namespace API
{
    public class Lista
    {
        private List<int> lista = new List<int>();

        public void Menu()
        {
            string opc;
            do
            {
                Console.WriteLine("\n[ LISTA ]");
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
            Console.Write("Digite o número: ");
            lista.Add(int.Parse(Console.ReadLine()));
        }

        private void Remover()
        {
            Console.Write("Digite o número para remover: ");
            int n = int.Parse(Console.ReadLine());
            lista.Remove(n);
        }

        private void Exibir()
        {
            Console.WriteLine("Lista:");
            foreach (int n in lista)
                Console.WriteLine(n);
        }

        private void Consultar()
        {
            Console.Write("Digite o número para buscar: ");
            int n = int.Parse(Console.ReadLine());
            int idx = lista.IndexOf(n);
            if (idx >= 0)
                Console.WriteLine($"Encontrado no índice {idx}");
            else
                Console.WriteLine("Não encontrado.");
        }
    }
}
