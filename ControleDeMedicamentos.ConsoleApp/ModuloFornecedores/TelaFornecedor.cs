using ControleDeMedicamentos.ConsoleApp.Compartilhado;

namespace ControleDeMedicamentos.ConsoleApp.ModuloFornecedores;

public class TelaFornecedor : TelaBase<Fornecedor>, ITelaOpcoes, ITelaCrud
{
    public TelaFornecedor(IRepositorio<Fornecedor> repositorio) : base("Fornecedor", repositorio)
    {
    }

    public override void VisualizarTodos(bool deveExibirCabecalho)
    {
        throw new NotImplementedException();
    }

    protected override Fornecedor ObterDadosCadastrais()
    {
        Console.Write("Digite o nome do fornecedor: ");
        string nome = Console.ReadLine() ?? string.Empty;

        Console.Write("Digite o telefone do fornecedor com DDD: ");
        string telefone = Console.ReadLine() ?? string.Empty;

        Console.Write("Digite o CNPJ do fornecedor: ");
        string cnpj = Console.ReadLine() ?? string.Empty;

        return new Fornecedor(nome, telefone, cnpj);
    }

}
