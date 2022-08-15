using System;
using System.Globalization;

namespace CalculadoraVetor
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            //Declarando variaveis

            int Xvet, Yvet, Zvet;
            double ProdEscalar, Cosseno, AreaTriangulo, AreaParalelogramo, Seno, Angulo, ProdVetorial, ModuloU, ModuloV;
            char resp;
            int casos = 0;

            int[] U = new int[3];
            int[] V = new int[3];

            //Entrada de Dados

            for (int i = 0; i < U.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.Write("Digite a posicão X do vetor U: ");

                        U[i] = int.Parse(Console.ReadLine());
                        break;

                    case 1:
                        Console.Write("Digite a posicão Y do vetor U: ");
                        U[i] = int.Parse(Console.ReadLine());
                        break;


                    case 2:
                        Console.Write("Digite a posicão Z do vetor U: ");
                        U[i] = int.Parse(Console.ReadLine());
                        break;
                }

            }

            Console.WriteLine();

            for (int i = 0; i < U.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.Write("Digite a posicão X do vetor V: ");
                        V[i] = int.Parse(Console.ReadLine());
                        break;

                    case 1:
                        Console.Write("Digite a posicão Y do vetor V: ");
                        V[i] = int.Parse(Console.ReadLine());
                        break;


                    case 2:
                        Console.Write("Digite a posicão Z do vetor V: ");
                        V[i] = int.Parse(Console.ReadLine());
                        break;
                }

            }

            Console.WriteLine();

            //Calculos

            Xvet = (U[1] * V[2]) - (V[1] * U[2]);
            Yvet = (U[0] * V[2]) - (V[0] * U[2]);
            Zvet = (U[0] * V[1]) - (V[0] * U[1]);

            ProdEscalar = (U[0] * V[0]) + (U[1] * V[1]) + (U[2] * V[2]);

            ProdVetorial = Math.Sqrt((Xvet * Xvet) + (Yvet * Yvet) + (Zvet * Zvet)) * 1.0;

            ModuloU = Math.Sqrt((U[0] * U[0]) + (U[1] * U[1]) + (U[2] * U[2]) * 1.0);
            ModuloV = Math.Sqrt((V[0] * V[0]) + (V[1] * V[1]) + (V[2] * V[2]) * 1.0);

            Cosseno = ProdEscalar / (ModuloU * ModuloV);

            AreaParalelogramo = ProdVetorial;

            AreaTriangulo = ProdVetorial / 2.0;

            Seno = ProdVetorial / (ModuloU * ModuloV);

            Angulo = Math.Asin(Seno) * (180 / Math.PI);

            //Menu de Opções

            Console.WriteLine("Menu de operações: ");
            Console.WriteLine("1 - Cosseno");
            Console.WriteLine("2 - Seno");
            Console.WriteLine("3 - Produto Escalar");
            Console.WriteLine("4 - Ângulo entre os vetores");
            Console.WriteLine("5 - Área do Triangulo");
            Console.WriteLine("6 - Área do paralelogramo");

            do
            {
                Console.WriteLine();
                Console.Write("Qual operação deseja escolher (1 - 6): ");
                casos = int.Parse(Console.ReadLine());

                //Operações

                switch (casos)
                {

                    case 1:
                        Console.WriteLine("O cosseno é igual a: " + Cosseno.ToString("F2", CultureInfo.InvariantCulture));
                        break;


                    case 2:
                        Console.WriteLine($"O seno é igual a: " + Seno.ToString("F2", CultureInfo.InvariantCulture));
                        break;


                    case 3:
                        Console.WriteLine($"Produto escalar: " + ProdEscalar.ToString("F2", CultureInfo.InvariantCulture));
                        break;


                    case 4:
                        Console.WriteLine($"O angulo entre os vetores é igual a: " + Angulo.ToString("F2", CultureInfo.InvariantCulture));
                        break;


                    case 5:
                        Console.WriteLine($"A área do triangulo é igual a: " + AreaTriangulo.ToString("F2", CultureInfo.InvariantCulture));
                        break;


                    case 6:
                        Console.WriteLine($"A área do paralelogramo é igual a: " + AreaParalelogramo.ToString("F2", CultureInfo.InvariantCulture));
                        break;

                    default:
                        Console.WriteLine("Opção inválida! É necessário fornecer um valor de 1 a 6!");
                        break;

                }

                Console.WriteLine();
                Console.Write("Deseja fazer novamente? (S/N): ");
                resp = char.Parse(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("----------------------------------");

            } while (resp == 'S' || resp == 's');

            Console.WriteLine();
            Console.WriteLine("Cálculo Terminado.");
        }
    }
}
