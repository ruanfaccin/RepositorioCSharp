using System;
using System.Globalization;

namespace ExCurso1MetodosClasse
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Retangulo R;

            R = new Retangulo();

            Console.Write("Digite o valor da base do retângulo: ");
            R.Base = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite o valor da altura do retângulo: ");
            R.Alt = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Área: {R.Area()}");
            Console.WriteLine($"Perímetro: {R.Perimetro()}");
            Console.WriteLine($"Diagonal: {R.Diagonal()}");

        }
    }
}
