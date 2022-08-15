using System;

namespace ExCursoVetor
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Quartos[] vet = new Quartos[10];

            String nome, email;
            int quarto;

            Console.Write("Quantos quartos desejam alugar? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Aluguel  #{i+1}");

                Console.Write("Nome: ");
                nome = Console.ReadLine();

                Console.Write("Email: ");
                email = Console.ReadLine();

                Console.Write("Quarto: ");
                quarto = int.Parse(Console.ReadLine());
                vet[quarto] = new Quartos(nome, email, quarto);
                Console.WriteLine();

            }


            for (int i = 0; i < 10; i++)
            {
                if (vet[i] != null)
                {
                    Console.WriteLine(i + ": "+ vet[i]);
                }
            }

        }
    }
}
