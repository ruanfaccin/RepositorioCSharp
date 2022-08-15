using System;
namespace ExCursoLista
{
    class Func
    {
        public string Nome { get; set; }
        public int Id { get; set; }
        public double Salario { get; private set; }

        public Func(int id, string nome, double salario)
        {
            Nome = nome;
            Id = id;
            Salario = salario;
        }

        public void Aumento(double porcentagem)
        {
            Salario += Salario * porcentagem / 100;
        }

        public override string ToString()
        {
            return Id + ", " + Nome + ", " + "R$" + Salario;
        }
    }
}