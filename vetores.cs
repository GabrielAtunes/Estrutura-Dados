namespace API
{
    public class Vetores
    {
        private int[] vetor = new int[5];
        private int index = 0;

        public void Menu()
        {
            string opc;
            do
            {
                Console.WriteLine("\n[ VETOR ]");
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
            if (index < vetor.Length)
            {
                Console.Write("Digite o valor: ");
                vetor[index] = int.Parse(Console.ReadLine());
                index++;
            }
            else
            {
                Console.WriteLine("Vetor cheio!");
            }
        }

        private void Remover()
        {
            if (index > 0)
            {
                index--;
                vetor[index] = 0;
                Console.WriteLine("Último elemento removido.");
            }
            else
            {
                Console.WriteLine("Vetor vazio.");
            }
        }

        private void Exibir()
        {
            Console.WriteLine("Elementos do vetor:");
            for (int i = 0; i < index; i++)
                Console.WriteLine(vetor[i]);
        }

        private void Consultar()
        {
            Console.Write("Digite o valor para buscar: ");
            int n = int.Parse(Console.ReadLine());
            int pos = Array.IndexOf(vetor, n);
            if (pos >= 0 && pos < index)
                Console.WriteLine($"Valor encontrado na posição {pos}.");
            else
                Console.WriteLine("Valor não encontrado.");
        }
    }
}
