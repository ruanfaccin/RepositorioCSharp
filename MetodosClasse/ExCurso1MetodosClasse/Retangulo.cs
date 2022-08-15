using System;
namespace ExCurso1MetodosClasse
{
    public class Retangulo
    {
        public double Base;
        public double Alt;

        public double Area()
        {
            return (Base * Alt);
        }

        public double Perimetro()
        {
            return (2 * (Base + Alt));
        }

        public double Diagonal()
        {
            return (Math.Sqrt(Base * Base + Alt * Alt));
        }

    }
}
