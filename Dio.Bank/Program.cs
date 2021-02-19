using System;

namespace Dio.Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta contaFernando = new Conta(TipoConta.PessoaFisica,"Fernando",500,562);



            Console.WriteLine(contaFernando);
           
        }
    }
}
