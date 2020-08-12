using System;

namespace Vendas
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Seja bem vindo!");
                Console.WriteLine("1 - Cadastrar Cliente");
                Console.WriteLine("2 - Listar Clientes");
                Console.WriteLine("3 - Cadastrar Vendedor");
                Console.WriteLine("4 - Listar Vendedores");
                Console.WriteLine("5 - Cadastrar Produto");
                Console.WriteLine("6 - Listar Produtos");
                Console.WriteLine("7 - Registrar Venda");
                Console.WriteLine("8 - Listar Vendas");
                Console.WriteLine("9 - Listar Vendas por Cliente");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("Escolha uma opção:");

                opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("--- CADASTRAR CLIENTE ---");
                        break;
                    case 2:
                        Console.WriteLine("--- LISTAR CLIENTES ---");
                        break;
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine();
                        break;
                }

                Console.WriteLine("Aperte uma tecla para continuar");
                Console.ReadKey();
            } while (opcao != 0);           

        }
    }
}
