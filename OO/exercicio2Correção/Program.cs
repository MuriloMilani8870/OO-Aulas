using System;

namespace exercicio2Correção {
    class Program {
        static void Main (string[] args) {

            Aluno[] alunos = new Aluno[2];
            int alunosCadastrados = 0;
            Sala[] salas = new Sala[1];
            int salasCadastradas = 0;
            int alunosAlocados = 0;

            bool querSair = false;
            do {
                Console.Clear ();
                System.Console.WriteLine ("===================================");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                System.Console.WriteLine ("        *** SENAIzinho ***         ");
                Console.ResetColor ();
                System.Console.WriteLine ("         Seja bem-vindo(a)         ");
                System.Console.WriteLine ("===================================");
                System.Console.WriteLine ("|| Digite sua opção:             ||");
                System.Console.WriteLine ("||  1 - Cadastrar Aluno          ||");
                System.Console.WriteLine ("||  2 - Cadastrar Sala           ||");
                System.Console.WriteLine ("||  3 - Alocar Aluno             ||");
                System.Console.WriteLine ("||  4 - Remover Aluno            ||");
                System.Console.WriteLine ("||  5 - Verificar Salas          ||");
                System.Console.WriteLine ("||  6 - Verificar Alunos         ||");
                System.Console.WriteLine ("||  0 - Sair                     ||");
                System.Console.WriteLine ("===================================");

                System.Console.Write ("Código: ");
                int codigo = int.Parse (Console.ReadLine ());

                switch (codigo) {
                    case 1:
                        Aluno aluno = new Aluno ();

                        System.Console.WriteLine ("Digite o nome do aluno");
                        aluno.nome = Console.ReadLine ();

                        System.Console.WriteLine ("Digite a data de nascimento (dd/mm/aaaa)");
                        aluno.dataNascimento = DateTime.Parse (Console.ReadLine ());

                        System.Console.WriteLine ("Digite o nome do curso");
                        aluno.curso = Console.ReadLine ();

                        // Console.WriteLine("Digite o numero da sala");
                        // aluno.numeroSala = int.Parse(Console.ReadLine());

                        alunos[alunosCadastrados] = aluno;

                        alunosCadastrados++;

                        Console.ForegroundColor = ConsoleColor.Green;
                        System.Console.WriteLine ("Cadastro de Aluno concluído!");
                        Console.ResetColor ();

                        System.Console.WriteLine ("Aperte ENTER para voltar ao menu");
                        Console.ReadLine ();

                        break;
                    case 2:
                        Sala sala = new Sala ();

                        System.Console.WriteLine ("Digite o número da sala");
                        sala.numeroSala = int.Parse (Console.ReadLine ());

                        System.Console.WriteLine ("Digite a capacidade total");
                        sala.capacidadeTotal = int.Parse (Console.ReadLine ());

                        sala.capacidadeAtual = sala.capacidadeTotal;

                        sala.alunos = new string[sala.capacidadeTotal];

                        salas[salasCadastradas] = sala;

                        salasCadastradas++;

                        Console.ForegroundColor = ConsoleColor.Green;
                        System.Console.WriteLine ("Cadastro de Sala concluído!");
                        Console.ResetColor ();

                        System.Console.WriteLine ("Aperte ENTER para voltar ao menu");
                        Console.ReadLine ();

                        break;

                    case 3:
                        Console.WriteLine("Insira o número de alunos que irão entrar nesta sala");
                        alunosAlocados = int.Parse (Console.ReadLine());

                        capacidadeAtual = alunosAlocados++;
                    break;

                    case 4:
                        
                    break;

                    case 5:
                        foreach (var item in salas) {
                            if (item != null) {
                                System.Console.WriteLine ("-----------------------------------------------------");
                                System.Console.WriteLine ($"Número da sala: {item.numeroSala}");
                                System.Console.WriteLine ($"Vagas disponíveis: {item.capacidadeAtual}");
                                System.Console.WriteLine ("-----------------------------------------------------");
                            }
                        }

                        System.Console.WriteLine ("Aperte ENTER para voltar ao menu principal");
                        Console.ReadLine ();
                        break;
                    case 6:
                        foreach (var item in alunos) {
                            if (item != null) {
                                System.Console.WriteLine ("-----------------------------------------------------");
                                System.Console.WriteLine ($"Nome do aluno: {item.nome}");
                                System.Console.WriteLine ($"Curso: {item.curso}");
                                System.Console.WriteLine ("-----------------------------------------------------");
                            }
                        }
                        System.Console.WriteLine ("Aperte ENTER para voltar ao menu principal");
                        Console.ReadLine ();

                        break;

                }

            } while (!querSair);
        }
    }
}