using System;

namespace exercicio2 {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Bem vindo ao software do Senaizinho");
            Console.WriteLine ("-----------------------------------");

            Aluno aluno = new Aluno();

            Sala sala = new Sala();

            string resposta2 ;
        
           
            bool repetir = true;
            while (repetir) {
      
                Console.WriteLine ("Selecione a opção desejada");
                Console.WriteLine ("-----------------------------------");
                Console.WriteLine ("1 - Cadastrar aluno");
                Console.WriteLine ("2 - Cadastrar sala");
                Console.WriteLine ("3 - Alocar aluno");
                Console.WriteLine ("4 - Remover Aluno");
                Console.WriteLine ("5 - Verificar Salas");
                Console.WriteLine ("6 - Verificar Alunos");
                Console.WriteLine ("0 - Sair");
                Console.WriteLine ("-----------------------------------");

                int resposta = int.Parse (Console.ReadLine ());

                switch (resposta) {
                    case 1:
                    do{
                        for (int i = 0; i < 4; i++)
                        {
                            
                        
                       
                        Console.WriteLine ("----------Cadastre o aluno----------");

                        Console.WriteLine ("Digite o Nome do Aluno");
                        aluno.nome = Console.ReadLine();

                        Console.WriteLine ("Digite a data de nascimento do aluno");
                        // aluno[].dataNascimento =DateTime.Parse(Console.Readline());
                    

                        Console.WriteLine ("Digite o curso do Aluno");
                        aluno.curso = Console.ReadLine();

                        }
                        

                        Console.WriteLine ("Deseja continuar cadastrando alunos?");
                        resposta2 = Console.ReadLine();


                        
                        
                    }while(resposta2 != "não");
                        
                        break;

                    case 2:
                        Console.WriteLine ("----------Cadastre a sala----------");

                        Console.WriteLine ("Digite o Número da sala");
                        sala.nSala = int.Parse(Console.ReadLine());

                        Console.WriteLine ("Digite a capacidade atual da sala");
                        sala.CapacAtual = int.Parse(Console.ReadLine());


                        Console.WriteLine ("Digite a capacidade total da sala");
                        sala.CapacTotal = int.Parse(Console.ReadLine());


                        break;
                    case 3:
                        Console.WriteLine ("Digite o Nome do Aluno e o Número da Sala para qual ele irá");

                        break;
                    case 4:
                        Console.WriteLine ("Digite o Nome do Aluno e ele será removido da sala");
                            sala.CapacTotal = sala.CapacTotal-1;

                        break;
                    case 5:
                        Console.WriteLine ("Essas são todas as características da sala:");
                        Console.WriteLine ($"A Sala de número {sala.nSala} possui a capacidade total de {sala.CapacTotal} alunos e está atualmente com {sala.CapacAtual} aluno(s)");

                        break;
                    case 6:
                    Console.WriteLine ("Essas são as listas dos alunos");
                    for (int i = 0; i < 4; i++)
                    {
                        Console.WriteLine ($"O Aluno {aluno.nome[i]} matriculado no curso {aluno.curso[i]} está...");
                    }

                        break;

                    case 0:
                        repetir = false;
                        break;

                    default:

                        break;
                }

            } //fim while

        }
    }
}