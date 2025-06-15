namespace API
{
    public class Pilha
    {
        private Stack<int> pilha = new Stack<int>();

        public void Menu()
        {
            string opc;
            do
            {
                Console.WriteLine("\n[ PILHA ]");
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
            pilha.Push(int.Parse(Console.ReadLine()));
        }

        private void Remover()
        {
            if (pilha.Count > 0)
                Console.WriteLine($"Removido: {pilha.Pop()}");
            else
                Console.WriteLine("Pilha vazia.");
        }

        private void Exibir()
        {
            Console.WriteLine("Pilha:");
            foreach (int n in pilha)
                Console.WriteLine(n);
        }

        private void Consultar()
        {
            Console.Write("Valor para buscar: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(pilha.Contains(n) ? "Está na pilha." : "Não encontrado.");
        }
    }
}
