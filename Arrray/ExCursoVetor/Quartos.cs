using System;
namespace ExCursoVetor
{
    public class Quartos
    {
        public String Nome { get; set; }
        public String Email { get; set; }
        public int Quarto { get; set; }

        public Quartos(string nome, string email, int quarto)
        {
            Nome = nome;
            Email = email;
            Quarto = quarto;
        }

        public override string ToString()
        {
            return Nome + ", " + Email ;
        }
    }
}
