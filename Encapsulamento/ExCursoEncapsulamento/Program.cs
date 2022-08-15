using System;
using System.Globalization;

namespace ExCursoEncapsulamento
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ContaBancaria Pessoa;

            Pessoa = new ContaBancaria();

            Console.Write("Entre com o número da conta: ");
            Pessoa.NConta = int.Parse(Console.ReadLine());

            Console.Write("Entre com o nome da usuário: ");
            Pessoa.Nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial? (s/n) ");
            Pessoa.Sim = Char.Parse(Console.ReadLine());

            if (Pessoa.Sim == 's')
            {
                Console.Write("Entre com o valor do depósito inicial: ");
                Pessoa.DepositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(Pessoa.Conta(), CultureInfo.InvariantCulture);

            Console.Write("Entre com um valor para depósito: ");
            Pessoa.Deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(Pessoa.Conta(), CultureInfo.InvariantCulture);

            Console.Write("Entre com um valor para saque: ");
            Pessoa.Saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(Pessoa.Conta(), CultureInfo.InvariantCulture);


        }
    }
}
