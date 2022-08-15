using System;

namespace Ex2CursoMatriz
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.Write("Deseja uma matriz com quantas linhas: ");
            int M = int.Parse(Console.ReadLine());

            Console.Write("Deseja uma matriz com quantas colunas: ");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine();

            int[,] matriz = new int[M, N];

            for (int linha = 0; linha < M; linha++)
            {
                for (int coluna = 0; coluna < N; coluna++)
                {
                    Console.Write($"Digite a posição ({linha + 1}, {coluna + 1}): ");
                    matriz[linha, coluna] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();
            Console.Write("Qual número deseja procurar? ");
            int proc = int.Parse(Console.ReadLine());

            Console.WriteLine();
            for (int linha = 0; linha < M; linha++)
            {
                for (int coluna = 0; coluna < N; coluna++)
                {
                    if (matriz [linha, coluna] == proc)
                    {
                        Console.WriteLine($"({linha+1}, {coluna+1})");

                        if (coluna > 0)
                        {
                            Console.WriteLine($"Esquerda: {matriz[linha, coluna - 1]}");
                        }
                        if (coluna < N - 1)
                        {
                            Console.WriteLine($"Direita: {matriz[linha, coluna + 1]}");
                        }
                        if (linha < M - 1)
                        {
                            Console.WriteLine($"Abaixo: {matriz[linha + 1, coluna]}");
                        }
                        if (linha > 0)
                        {
                            Console.WriteLine($"Acima: {matriz[linha - 1, coluna]}");
                        }

                    }
                }
            }
        }
    }
}
