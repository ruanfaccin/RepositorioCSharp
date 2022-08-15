using System;

namespace ExAulaVetorSemRepeticao
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            string[] nomes = new string[10];
            string entrada;
            bool encontrou;

            int i = 0;
            while (i < 10)
            {

                Console.Write($"Digite um nome [{i}]: ");
                entrada = Console.ReadLine();

                encontrou = false;

                for (int j = 0; j < i; j++)
                {
                    if (nomes[j].ToUpper() == entrada.ToUpper())
                    {
                        encontrou = true;
                        break;
                    }
                }

                if (encontrou)
                {
                    Console.WriteLine("Nome digitado já existe! Digite outro!");
                }
                else
                {
                    nomes[i] = entrada;
                    i++;
                }
            }

            Console.WriteLine();

            //a.compareto(b) -> retorna 0 se é igual a b, retorna < 0 se a é menor que b, e retrona > 0 se a é maior que b

            for (int k = 0; k < nomes.Length - 1; k++)
            {
                for (int l = k + 1; l < nomes.Length; l++)
                {
                    if (nomes[k].CompareTo(nomes[l]) > 0)
                    {
                        string aux = nomes[k];
                        nomes[k] = nomes[l];
                        nomes[l] = aux;
                    }
                }
            }

            for(int k = 0; k < nomes.Length; k++)
            {
                Console.WriteLine(nomes[k]);
            }

            Console.Write("Digite um nome para ser procurado: ");
            string entradas = Console.ReadLine();

            Console.WriteLine();
            bool encontrado = false;

            for (int j = 0; j < i; j++)
            {
                if (nomes[j].ToUpper() == entradas.ToUpper())
                {
                    encontrado = true;
                }

                if (encontrado)
                {
                    Console.WriteLine($"O nome está no indíce {j}");
                    break;
                }
                else
                {
                    Console.WriteLine("O nome digitado não existe!");
                    break;
                }
            }
            
        }
    }
}
