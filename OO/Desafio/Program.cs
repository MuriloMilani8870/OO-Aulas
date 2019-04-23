using System;

namespace Desafio {
    class Program {
        static void Main (string[] args) {
            bool sair = false;

            Usuario[] usuarios = new Usuario[2];
            int usuariosCadastrados = 0;

            do {
                Console.Clear ();
                System.Console.WriteLine ("===================================");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                System.Console.WriteLine ("              PiTsuka      ");
                Console.ResetColor ();
                System.Console.WriteLine ("         Seja bem-vindo(a)         ");
                System.Console.WriteLine ("===================================");
                System.Console.WriteLine ("||      Digite sua opção:        ||");
                System.Console.WriteLine ("||  1 - Cadastrar Usuário        ||");
                System.Console.WriteLine ("||  2 - Efetuar login            ||");
                System.Console.WriteLine ("||  3 - Listar Usuário           ||");
                System.Console.WriteLine ("||  9 - Sair                     ||");
                System.Console.WriteLine ("===================================");

                System.Console.Write ("Código: ");

                int codigo = int.Parse (Console.ReadLine ());

                switch (codigo) {
                    case 1:

                        for (int i = 0; i < 1; i++) {

                            Usuario usuario = new Usuario ();

                            System.Console.WriteLine ("Digite seu nome");
                            usuario.nome = Console.ReadLine ();

                            System.Console.WriteLine ("Digite seu email");
                            usuario.email = Console.ReadLine ();

                            System.Console.WriteLine ("Digite uma senha");
                            usuario.senha = Console.ReadLine ();

                            usuarios[usuariosCadastrados] = usuario;

                            usuariosCadastrados++;

                            Random r = new Random ();
                            usuario.id = r.Next (0, 10);

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine ($"Cadastro concluido em {usuario.data:dd/MM/yyyy}");
                            Console.ResetColor ();

                            Console.WriteLine ("Aperte ENTER para voltar ao menu.");
                            Console.ReadLine ();
                        }
                        break;

                    case 2: 
                    
                    System.Console.WriteLine ("----------Login----------");
                    if (usuariosCadastrados == 0) {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            System.Console.WriteLine ("Nenhum usuario cadastrado!");
                            Console.ResetColor ();

                            System.Console.WriteLine ("Aperte ENTER para voltar ao menu");
                            Console.ReadLine ();
                            continue;
                    }
                       
                        Console.WriteLine ("Digite o seu usuário");
                        string nomeUsuario = Console.ReadLine ();
                        Usuario usuarioRecuperado = null;
                        foreach (Usuario item in usuarios) {
                            if (item != null && nomeUsuario.Equals(item.nome)) {

                                usuarioRecuperado = item;
                                break;
                            }
                        }
                        if (usuarioRecuperado == null) {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            System.Console.WriteLine ($"Usuário {nomeUsuario} não encontrado!");
                            Console.ResetColor ();

                            System.Console.WriteLine ("Aperte ENTER para voltar ao menu");
                            Console.ReadLine ();
                            continue;
                        }
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine ($"Seja bem vindo {nomeUsuario}");
                        Console.ResetColor ();

                        System.Console.WriteLine ("Aperte ENTER para voltar ao menu");
                        Console.ReadLine ();
                        break;

                    case 3:
                     if (usuariosCadastrados == 0) {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            System.Console.WriteLine ("Nenhum usuario cadastrado!");
                            Console.ResetColor ();

                            System.Console.WriteLine ("Aperte ENTER para voltar ao menu");
                            Console.ReadLine ();
                            continue;
                    }
                        foreach (var item in usuarios) {
                            if (item != null) {
                                Random r = new Random ();
                                System.Console.WriteLine ("-----------------------------------------------------");
                                System.Console.WriteLine ($"ID: {item.id}");
                                System.Console.WriteLine ($"Usuario: {item.nome}");
                                System.Console.WriteLine ($"Email: {item.email}");
                                System.Console.WriteLine ("-----------------------------------------------------");
                            }
                        }
                        System.Console.WriteLine ("Aperte ENTER para voltar ao menu principal");
                        Console.ReadLine ();

                        break;

                    case 9:
                    Console.WriteLine("Obrigado! Volte sempre!");
                        sair = true;
                        break;
                }

            } while (!sair);
        }
    }
}