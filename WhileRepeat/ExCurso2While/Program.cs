using System;

namespace ExCurso2While
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string coor;

            Console.Write("Digite as coordenadas: ");
            coor = Console.ReadLine();

            string[] vet = coor.Split(' ');
            int vet1 = int.Parse(vet[0]);
            int vet2 = int.Parse(vet[1]);

            while (vet1 != 0 && vet2 != 0)
            {

                if (vet1 > 0 && vet2 > 0)
                {
                    Console.WriteLine("Está no primeiro quadrante!");
                }
                else if (vet1 < 0 && vet2 > 0)
                {
                    Console.WriteLine("Está no segundo quadrante!");
                }
                else if (vet1 < 0 && vet2 < 0)
                {
                    Console.WriteLine("Está no terceiro quadrante!");
                }
                else
                {
                    Console.WriteLine("Está no quarto quadrante!");
                }

                vet = Console.ReadLine().Split(' ');
                vet1 = int.Parse(vet[0]);
                vet2 = int.Parse(vet[1]);

                Console.WriteLine("Programa encerrado!");

            }
        }
    }
}
