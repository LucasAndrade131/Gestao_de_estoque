namespace empresa;

class Program
{
    static void Main(string[] args)
    {
        Produto[] produtos = new Produto[0];
        Estoque estoque = new Estoque();

        int menu = 0;
        do
        {
            
            Console.WriteLine("========== Menu Principal ==========");
            Console.WriteLine("[1] Novo Produto");
            Console.WriteLine("[2] Listar Produtos");
            Console.WriteLine("[3] Remover Produtos");
            Console.WriteLine("[4] Entrada Estoque");
            Console.WriteLine("[5] Saída Estoque");
            Console.WriteLine("[0] Sair");
            Console.WriteLine("===================================");

            Console.Write("Escolha uma opção: ");
            menu = Convert.ToInt32(Console.ReadLine());

            if (menu == 1)
            {

                Produto novoProduto = new Produto();

                Console.WriteLine("Nome da Camisa:");
                novoProduto.Nome = Console.ReadLine();

                Console.WriteLine("Preço:");
                novoProduto.Preco = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Marca:");
                novoProduto.Marca = Console.ReadLine();

                Console.WriteLine("Gênero:");
                novoProduto.Genero = Console.ReadLine();

                Console.WriteLine("Ano de Lançamento:");
                novoProduto.AnoCamisa = Convert.ToInt32(Console.ReadLine());

                estoque.AdicionarProduto(novoProduto);
            } else if (menu == 2)
            {
                Console.WriteLine("\nItens no Estoque:");
                estoque.ListarProdutos();
            } else if (menu == 3)
            {
                Console.WriteLine("\nItens no Estoque:");
                estoque.ListarProdutos();

                Console.WriteLine("Posição do Produto a ser Removido:");
                int pos = Convert.ToInt32(Console.ReadLine());

                estoque.RemoverProdutos(pos);
                Console.WriteLine("Produto removido do estoque.");
            } else if (menu == 4)
            {
                Console.WriteLine("\nItens no Estoque");
                estoque.ListarProdutos();

                Console.WriteLine("Posição da Camisa:");
                int pos = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Quantidade de Entrada:");
                int qtd = Convert.ToInt32(Console.ReadLine());

                estoque.EntradaProdutos(pos, qtd);

            } else if (menu == 5)
            {
                Console.WriteLine("\nItens no Estoque:");
                estoque.ListarProdutos();

                Console.WriteLine("Posição do Produto:");
                int pos = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Quantidade de Saída:");
                int qtd = Convert.ToInt32(Console.ReadLine());

                estoque.SaidaProdutos(pos, qtd);
                Console.WriteLine("Saída registrada.");
            } 
        }
        while (menu != 0);
    }
}
