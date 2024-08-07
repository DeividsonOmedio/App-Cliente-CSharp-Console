using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppClientes.menu
{
    public static class Clientes
    {
        static ClienteRepositorio _clienteRepositorio = new ClienteRepositorio();
        public static void Menu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;

            Console.WriteLine("\n\t| Cadastro de Clientes  |");
            Console.WriteLine("\t| --------------------  |");
            Console.WriteLine("\t| 1 - Cadastrar Cliente |");
            Console.WriteLine("\t| 2 - Exibir Clientes   |");
            Console.WriteLine("\t| 3 - Editar Cliente    |");
            Console.WriteLine("\t| 4 - Excluir Cliente   |");
            Console.WriteLine("\t| 5 - Sair              |");
            Console.WriteLine("\t| --------------------  |\n");

            Console.WriteLine(_clienteRepositorio.Clientes);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("");
            EscolherOpcao();
        }


        static void EscolherOpcao()
        {
            Console.Write("Escolha uma opção: ");

            var opcao = Console.ReadLine();

            switch (int.Parse(opcao))
            {
                case 1:
                    {
                        _clienteRepositorio.CadastrarCliente();
                        Menu();
                        break;
                    }
                case 2:
                    {
                        _clienteRepositorio.ExibirClientes();
                        Menu();
                        break;
                    }
                case 3:
                    {
                        _clienteRepositorio.EditarCliente();
                        Menu();
                        break;
                    }
                case 4:
                    {
                        _clienteRepositorio.ExcluirCliente();
                        Menu();
                        break;
                    }
                case 5:
                    {
                        _clienteRepositorio.GravarDadosClientes();
                        Console.WriteLine("Saindo...");
                        // colocar um atraso para sair do programa
                        Thread.Sleep(1000);
                        Console.WriteLine("Programa Ecerrado!");
                        Environment.Exit(0);
                        break;
                    }
                default:
                    {
                        Console.Clear();
                        Console.WriteLine("Opção Inválida!");
                        break;
                    }
            }
        }
    }
}