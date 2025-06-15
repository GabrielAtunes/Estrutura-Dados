namespace API
{
    public class Fila
    {
        private Queue<int> fila = new Queue<int>();

        public void Menu()
        {
            string opc;
            do
            {
                Console.WriteLine("\n[ FILA ]");
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
            Console.Write("Digite o valor: ");
            fila.Enqueue(int.Parse(Console.ReadLine()));
        }

        private void Remover()
        {
            if (fila.Count > 0)
                Console.WriteLine($"Removido: {fila.Dequeue()}");
            else
                Console.WriteLine("Fila vazia.");
        }

        private void Exibir()
        {
            Console.WriteLine("Fila:");
            foreach (int n in fila)
                Console.WriteLine(n);
        }

        private void Consultar()
        {
            Console.Write("Valor para buscar: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(fila.Contains(n) ? "Está na fila." : "Não encontrado.");
        }
    }
}
