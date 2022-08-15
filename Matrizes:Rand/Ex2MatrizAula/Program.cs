using System;

namespace Ex2MatrizAula
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            int[,] matriz = new int[4, 3];
            int[] vet = new int [4];
            Random rnd = new Random();


            //caso fosse randomico
            /*for (int linha = 0; linha < 4; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    Console.Write($"Digite o valor da matriz [{linha + 1}, {coluna + 1}]: ");
                    matriz[linha, coluna] = rnd.Next(1, 1000);
                    Console.WriteLine($"Matriz [{linha}, {coluna}: " + $"{matriz[linha, coluna]})";

                    vet[linha] += matriz[linha, coluna];
                }
            }*/

            for (int linha = 0; linha < 4; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    Console.Write($"Digite o valor da matriz [{linha+1}, {coluna+1}]: ");
                    matriz[linha, coluna] = int.Parse(Console.ReadLine());

                    vet[linha] += matriz[linha, coluna];
                }
            }


            Console.WriteLine();



            for (int linha = 0; linha < 4; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    Console.Write($"{matriz[linha, coluna]}\t ");
                }
                Console.WriteLine();
            }


            Console.WriteLine();

            for (int i = 0; i < vet.Length; i++)
            {
                Console.WriteLine($"A soma da linha {i+1} = {vet[i]}");
            }

        }
    }
}
