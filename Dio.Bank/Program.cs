using System;

namespace Dio.Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            var contaFernando = new Conta(TipoConta.PessoaFisica,"Fernando",500,562);

            
           
           
        }

        private static string PainelUsuario()
        {
            Console.WriteLine("Dio Bank sempre ao seu lado!");
            Console.WriteLine("Informe a opção desejada");
            Console.WriteLine("Listar Contas");
            Console.WriteLine("Inserir nova conta");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            
        }
    }
}
