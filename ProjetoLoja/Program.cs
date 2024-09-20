using System.Globalization;
using ProjetoLoja.uteis;

Estoque estoque = new Estoque();
bool rodando = true;

do 
{
    Console.WriteLine("O que deseja fazer?");
    Console.WriteLine("1 - Listar estoque");
    Console.WriteLine("2 - Adicionar produto");
    Console.WriteLine("3 - Remover produto");
    Console.WriteLine("0 - Fechar programa");

    try
    {
        byte escolha = byte.Parse(Console.ReadLine());
        switch (escolha)
        {
            case 0:
                rodando = false;
                Console.Clear();
                Console.WriteLine("Você escolheu sair!");
                break;
            case 1:
                var prodt = estoque.ListarProdutos();
                if (prodt.Count > 0)
                {
                    Console.Clear();
                    foreach (var produto in estoque.ListarProdutos())
                    {
                        Console.WriteLine($"ID: {produto.IdProduto}\nNome: {produto.NomeProduto}\nQuantidade: {produto.QuantidadeProduto}\nPreço: {produto.PrecoProduto}");
                        Console.WriteLine(' ');
                    }
                    mesnsagemConsole();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Estoque vazio!");
                    mesnsagemConsole();
                }
                break;
            case 2:
                Console.Clear();
                Console.WriteLine("Insira as informações do produto:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Quantidade: ");
                int quantidade = int.Parse(Console.ReadLine());
                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (estoque.AdicionarProduto(new Produtos { IdProduto = id, NomeProduto = nome, QuantidadeProduto = quantidade, PrecoProduto = preco }))
                {
                    Console.Clear();
                    Console.WriteLine("Produto adicionado com sucesso!");
                    mesnsagemConsole();

                }
                break;
            default:
                Console.Clear();
                Console.WriteLine("Valor inválido");
                mesnsagemConsole();
                break;
        }
    }
    catch (Exception)
    {
        Console.Clear();
        Console.WriteLine("Valor inválido");
        mesnsagemConsole();
    }
} 
while (rodando);


static void mesnsagemConsole()
{
    Console.WriteLine("Pressione qualquer tecla para continuar...");
    Console.ReadLine();
    Console.Clear();
}
