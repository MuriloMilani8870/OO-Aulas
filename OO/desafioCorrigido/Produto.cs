using System;

namespace desafioCorrigido {
    public class Produto {

        static Produto[] Produtos = new Produto[1000];

        static int contador2 = 0;

        public int IDProduto { get; set; }

        public string NomeProduto { get; set; }

        public string DescricaoProduto { get; set; }

        public int PreçoProduto { get; set; }

        public string CategoriaProduto { get; set; }

        public DateTime DataProduto { get; set; }

        public static void CadastrarProduto () {

            string nomeproduto;

            string descricaoproduto;

            int preçoproduto;

            string categoriaproduto;

            Console.WriteLine ("Digite o nome do Produto:");
            nomeproduto = Console.ReadLine ();

            Console.WriteLine ("Digite a descrição do produto:");
            descricaoproduto = Console.ReadLine ();

            Console.WriteLine ("Digite o preço do Produto:");
            preçoproduto = int.Parse (Console.ReadLine ());

            do {
                Console.WriteLine ("Digite a categoria do Produto.");
                Console.WriteLine ("Obs. A PITsuka trabalha apenas com Pizzas e Bebidas, por favor seja coerente.");
                categoriaproduto = Console.ReadLine ();
                if (!categoriaproduto.Contains ("Pizza") && !categoriaproduto.Contains ("Bebida")) {
                    Console.WriteLine ("Categoria Inválida");
                }
            } while (!categoriaproduto.Contains ("Pizza") && !categoriaproduto.Contains ("Bebida"));

            Produtos[contador2] = new Produto ();
            Produtos[contador2].IDProduto = contador2 + 1;
            Produtos[contador2].NomeProduto = nomeproduto;
            Produtos[contador2].DescricaoProduto = descricaoproduto;
            Produtos[contador2].PreçoProduto = preçoproduto;
            Produtos[contador2].CategoriaProduto = categoriaproduto;
            Produtos[contador2].DataProduto = DateTime.Now;
            contador2++;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine ("Produto registrado com sucesso");
            Console.ResetColor ();

            System.Console.WriteLine ("Aperte ENTER para voltar ao menu");
            Console.ReadLine ();
        }

        public static void ListarProduto () {
            foreach (var item in Produtos) {
                if (item == null) {
                    break;
                }
                System.Console.WriteLine ("-----------------------------------------------------");
                System.Console.WriteLine ($"ID: {item.IDProduto}");
                System.Console.WriteLine ($"Nome do Produto: {item.NomeProduto}");
                System.Console.WriteLine ($"Preço do produto: ${item.PreçoProduto}");
                System.Console.WriteLine ("-----------------------------------------------------");

            }
            System.Console.WriteLine ("Aperte ENTER para voltar ao menu");
            Console.ReadLine ();
        }
        public static void Busca () {
            Console.WriteLine ("Digite o número do ID que você deseja buscar:");
            int idBusca = int.Parse (Console.ReadLine ());

            Produto IDrecuperado = null;
            foreach (Produto item in Produtos) {
                if (item != null && idBusca.Equals (item.IDProduto)) {
                    IDrecuperado = item;

                    System.Console.WriteLine ($"ID do Produto: {Produtos[idBusca-1].IDProduto}");
                    System.Console.WriteLine ($"Nome do Produto: {Produtos[idBusca-1].NomeProduto}");
                    System.Console.WriteLine ($"Descrição do Produto: {Produtos[idBusca-1].DescricaoProduto}");
                    System.Console.WriteLine ($"Preço do Produto: {Produtos[idBusca-1].PreçoProduto}");
                    System.Console.WriteLine ($"Categoria do Produto: {Produtos[idBusca-1].CategoriaProduto}");
                    System.Console.WriteLine ($"Data do Produto: {Produtos[idBusca-1].DataProduto}");

                    System.Console.WriteLine ("Aperte ENTER para voltar ao menu");
                    Console.ReadLine ();

                    break;
                } else {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine ("Produto Não cadastrado");
                    Console.ResetColor ();

                }
                System.Console.WriteLine ("Aperte ENTER para voltar ao menu");
                Console.ReadLine ();
            }
        }
    }
}