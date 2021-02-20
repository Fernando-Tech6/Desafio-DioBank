using System;
using System.Collections.Generic;

namespace Dio.Bank
{
    class Program
    {
        static List<Conta> listaContas = new List<Conta>(); 
        static void Main(string[] args)
        {

            string opcao = PainelUsuario();
                
           while (opcao.ToUpper() != "X")
            {
                switch(opcao)
                {
                    case "1":
                        ListarContas();
                        break;
                    case "2":
                        InserirConta();
                        break;
                    case "3":
                        Saldo();
                        break;
                    case "4":
                        Saque();
                        break;
                    case "5":
                        Transferencia();
                        break;
                    case "6":
                        Deposito();
                        break;
                    case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcao = PainelUsuario();

            }

            Console.WriteLine("Obrigado por utilizar nosso serviços.");
            
        }

        private static void Saldo()  // ao solicitar apenas o saldo.
        {
            Console.Write("Digite o número da conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            listaContas[indiceConta].ContaSaldo(listaContas[indiceConta]);
        }

        private static void Transferencia()
        {
            Console.Write("Digite o número da conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o número da conta do destinatario: ");
            int indiceOutraConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser transferido: ");
            double valorTransferencia = double.Parse(Console.ReadLine());

            listaContas[indiceConta].Transferir(valorTransferencia, listaContas[indiceOutraConta]);
         
        }

        private static void Deposito()
        {
            Console.Write("Digite o número da conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser depositado: ");
            double valorDeposito = double.Parse(Console.ReadLine());

            listaContas[indiceConta].Depositar(valorDeposito);
        }

        private static void Saque()
        {
            Console.Write("Digite o número da conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser sacado: ");
            double valorSaque = double.Parse(Console.ReadLine());

            listaContas[indiceConta].Sacar(valorSaque);
        }

        private static void ListarContas()
        {
            if (listaContas.Count == 0)
            {
                Console.WriteLine("Nenhuma conta cadastrada.");
                return;   // Para finalizar e não continuar com o código abaixo.
            }

            for (int i = 0; i <listaContas.Count; i++)
            {
                Conta conta = listaContas[i];
                Console.Write("*{0} - ", i);
                Console.WriteLine(conta);
               
            }
        }

        private static void InserirConta()
        {
            Console.Write("Digite 1 para Conta Fisica ou 2 para Conta Juridica: ");
            int novoTipoConta = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o Nome do Cliente: ");
            string novoNome = Console.ReadLine();

            Console.Write("Digite o saldo inicial: ");
            double novoSaldo = Convert.ToDouble(Console.ReadLine());

            Conta novaConta = new Conta(tipoConta: (TipoConta)novoTipoConta,   // posso colocar um argumento nomeado, onde eu nomeio e separo por: + um argumento.
                                        nome: novoNome,
                                        saldo: novoSaldo
                                        );

            listaContas.Add(novaConta );
        }

        private static string PainelUsuario()
        {
            Console.WriteLine(" \n Dio Bank sempre ao seu lado!");
            Console.WriteLine(" Informe a opção desejada:\n");
            Console.WriteLine(" 1 - Listar Contas");
            Console.WriteLine(" 2 - Inserir nova conta");
            Console.WriteLine(" 3 - Saldo");
            Console.WriteLine(" 4 - Sacar");
            Console.WriteLine(" 5 - Transferir");
            Console.WriteLine(" 6 - Depositar");
            Console.WriteLine(" C - Limpar Tela");
            Console.WriteLine(" X - Sair");

            string opcao = Console.ReadLine().ToUpper();
            Console.Clear();  // Para Limpar a tela após a lista de opções.
            return opcao;
            
        }
    }
}
