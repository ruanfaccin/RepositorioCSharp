using System;
using System.Collections.Generic;

namespace ExCursoLista
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.Write("Quantas pessoas deseja registrar: ");
            int n = int.Parse(Console.ReadLine());

            List<Func> list = new List<Func>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Empregado {i}: ");

                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine());
                Console.WriteLine();

                list.Add(new Func(id, nome, salario));
            }

            Console.Write("Digite o Id do funcionário para aumentar o salário: ");
            int ProcurarId = int.Parse(Console.ReadLine());

            Func AcharId = list.Find(x => x.Id == ProcurarId);

            if (AcharId == null)
            {
                Console.WriteLine("O funcionário não existe!");
            }
            else
            {
                Console.Write("Digite o aumento para o funcionário: ");
                double porcentagem = double.Parse(Console.ReadLine());
                AcharId.Aumento(porcentagem);

            }

            Console.WriteLine("Lista atualizada de funcionários: ");
            foreach (Func obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
