using System;
using desafioCorrigido;

namespace DesafioPizzaria {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Bem vindo a Pizzaria do Tsukamoto");
            int escolha = 0;
            do {

                Console.WriteLine ("1 -- Cadastrar Usuário");
                Console.WriteLine ("2 -- Login");
                Console.WriteLine ("3 -- Listar Usuário");
                Console.WriteLine ("9 - Sair");
                escolha = int.Parse (Console.ReadLine ());

                switch (escolha) {
                    case 1:
                        //Cadastro do usuário
                        Usuario.Inserir ();
                        // Usuario.Listar();
                        break;
                    case 2:
                        // Efetuar login
                        Usuario.EfetuarLogin ();
                        //Colocar o segundo Menu
                        bool sair = false;
                        do {
                            Console.Clear ();
                            System.Console.WriteLine ("===================================");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            System.Console.WriteLine ("              PiTsuka      ");
                            Console.ResetColor ();
                            System.Console.WriteLine ("         Seja bem-vindo(a)         ");
                            System.Console.WriteLine ("===================================");
                            System.Console.WriteLine ("||      Digite sua opção:        ||");
                            System.Console.WriteLine ("||  1 - Cadastrar produto        ||");
                            System.Console.WriteLine ("||  2 - Listar produtos          ||");
                            System.Console.WriteLine ("||  3 - Buscar ID                ||");
                            System.Console.WriteLine ("||  9 - Logout                   ||");
                            System.Console.WriteLine ("===================================");

                            System.Console.Write ("Código: ");

                            int codigo = int.Parse (Console.ReadLine ());

                            switch (codigo) {
                                case 1:
                                    Produto.CadastrarProduto ();
                                    break;

                                case 2:
                                    Produto.ListarProduto ();
                                    break;

                                case 3:
                                    Produto.Busca();
                                    break;

                                case 9:
                                    Console.WriteLine ("Obrigado! Volte sempre!");
                                    sair = true;
                                    break;
                            }

                        } while (!sair);

                        break;
                    case 3:
                        // Listar Usuarios
                        Usuario.Listar ();
                        break;
                    case 9:
                        // Sair do sistema
                        break;

                    default:
                        Console.WriteLine ("Valor inválido");
                        break;
                }

            } while (escolha != 9);

        }
    }
}