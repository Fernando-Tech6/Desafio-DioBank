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


    }

    
}
