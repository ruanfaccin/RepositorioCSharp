using System;
using System.Globalization;

namespace ExCurso3MetodosClasse
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Aluno A;

            A = new Aluno();

            Console.Write("Digite seu nome: ");
            A.Nome = Console.ReadLine();

            Console.Write("Digite sua primeira nota: ");
            A.N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite sua segunda nota: ");
            A.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite sua terceira nota: ");
            A.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.WriteLine($"Nota Final: {A.Final()} ");

            if (A.Aprovado() == true)
            {
                Console.WriteLine($"A/0 {A.Nome} foi APROVADO!");
            }
            else
            {
                Console.WriteLine($"A/0 {A.Nome} foi REPROVADO!");
                Console.WriteLine($"Nota Faltante: {A.NotaFaltante()} ");
            }

        }
    }
}
