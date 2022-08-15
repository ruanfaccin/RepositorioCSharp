using System;
namespace ExCurso3MetodosClasse
{
    public class Aluno
    {
        public string Nome;
        public double N1, N2, N3;

        public double Final()
        {
            return (N1 + N2 + N3);
        }


        public bool Aprovado()
        {
            if (Final() >= 90.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double NotaFaltante()
        {
            if (Final() >= 90.0)
            {
                return 0.0;
            }
            else
            {
                return 90.0 - Final();
            }
        }
    }
}
