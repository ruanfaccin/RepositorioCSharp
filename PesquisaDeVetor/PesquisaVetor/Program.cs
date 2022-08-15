using System;

namespace PesquisaVetor
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.Write("Digite quantos números precisa digitar: ");
            int quant = int.Parse(Console.ReadLine());

            int[] vet = new int[quant];

            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write($"Digite o número #{i+1}: ");
                vet[i] = int.Parse(Console.ReadLine());
            }


            for (int j = 0; j < vet.Length - 1; j++)
            {
                for (int k = j+1; k < vet.Length; k++)
                {
                    if (vet[j] > vet[k])
                    {
                        int aux = vet[j];
                        vet[j] = vet[k];
                        vet[k] = aux;
                    }
                }
            }

            Console.WriteLine();

            for (int j = 0; j < vet.Length; j++)
            {
                Console.Write($"{vet[j]}\t");
            }

        }
    }
}
