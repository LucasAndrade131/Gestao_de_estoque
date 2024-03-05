public class Estoque
{
    Produto[] produtos = new Produto[0];
    public void AdicionarProduto(Produto produto)
    {
        Produto[] novoVetor = new Produto[produtos.Length +1];
        for (int pos =0; pos < produtos.Length; pos++)
        {
            Produto item = produtos[pos];
            novoVetor[pos] = item;
        }
        novoVetor[novoVetor.Length - 1] = produto;

        produtos = novoVetor;
        Console.WriteLine("Produto adicionado com sucesso.");
    }

    public void ListarProdutos()
    {
        int cont = 1;
        foreach (Produto item in produtos) 
        {
            Console.WriteLine($"{cont}. {item.Nome} ({item.Preco}) - {item.Estoque} no estoque");
            cont++;
        }
    }

    public void EntradaProdutos(int pos, int qtd)
    {
        Produto produto = produtos[pos - 1];
        produto.Estoque += qtd;
    }

    public void SaidaProdutos(int pos, int qtd)
    {
        Produto produto = produtos[pos - 1];
        if (produto.Estoque >= qtd)
        {
            produto.Estoque -= qtd;
        }
        else
        {
        Console.WriteLine("Quantidade insuficiente em estoque.");
        }
        }

    public void RemoverProdutos(int pos)
    {
        if (pos > 0 && pos <= produtos.Length)
    {
        Produto[] novoVetor = new Produto[produtos.Length - 1];
        int j = 0;
        for (int i = 0; i < produtos.Length; i++)
        {
            if (i != pos - 1)
            {
                novoVetor[j] = produtos[i];
                j++;
            }
        }
        produtos = novoVetor;
    }
    else
    {
        Console.WriteLine("Posição inválida.");
    }
    }
}