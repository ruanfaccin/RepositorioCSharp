using System;
namespace ExCursoEncapsulamento
{
    public class ContaBancaria
    {

        public string Nome { get; set; } 
        public int NConta { get; set; }
        public double Saque { get; set; }
        public double DepositoInicial { get; set; }
        public double Deposito {get; set; }
        public char Sim;

 
        public ContaBancaria ()
        {

        }

        public ContaBancaria(int nConta)
        {
            NConta = nConta;
          

        }

        public ContaBancaria(string nome, double saque, double depositoInicial, double deposito)
        {
            Nome = nome;
            Saque = saque;
            DepositoInicial = depositoInicial;
            Deposito = deposito;
        }

        private double ValorConta ()
        {
            if (Saque != 0)
            {
                return 0 + DepositoInicial + Deposito - Saque - 5;
            }
            else
            {
                return 0 + DepositoInicial + Deposito;


            }
        }



        public string Conta()
        {
            return $"Titular: "+ Nome +
                ", Conta: " + NConta + ", Saldo: R$" + ValorConta();
        } 


    }
}
