using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dio.Bank
{
    public class Conta
    {
        

        private TipoConta tipoConta { get; set; }
        private string Nome { get; set; }
        private double Saldo { get; set; }
        private double Credito { get; set; }


        public Conta(TipoConta tipoConta, string nome, double saldo, double credito)
        {
            this.tipoConta = tipoConta;
            Nome = nome;
            Saldo = saldo;
            Credito = credito;
        }

        public bool Sacar(double valorSaque)
        {
            if (Saldo - valorSaque < (Credito * -1))  // Se o valor do saque for maior que o saldo + credito.
            {
                Console.WriteLine("Saldo Insuficiente!!");
                return false;
            }

            Saldo -= valorSaque;
            Console.WriteLine($"Saldo atual da conta de {Nome} é {Saldo}");
            return true;
        }

        public void Depositar(double valorDeposito)
        {
            Saldo += valorDeposito;
            Console.WriteLine($"Saldo atual da conta de {Nome} é {Saldo}");

        }

        public void Transferir(double valorTransferencia, Conta contaDestino)
        {
            if (Sacar(valorTransferencia))
            {
                contaDestino.Depositar(valorTransferencia);
            }
           

        }

        public override string ToString()
        {   // Sobreescrevendo o metodo para acessar as informações do objeto no console.

            string retorno = "";
            retorno += "Tipo da Conta: " + tipoConta + " | ";
            retorno += "Nome: " + Nome + " | ";
            retorno += "Saldo: " + Saldo + " | ";
            retorno += "Credito: " + Credito + " | ";
            return retorno;

        }

        public void ContaSaldo(Conta conta)  
        {
            Console.WriteLine($"O saldo atual da conta de {Nome} é de R$ {conta.Saldo}" +
                $" com crédito de  {conta.Credito}" );
        }

    }

    
}
