using ControleDeMedicamentos.ConsoleApp.Compartilhado;
using ControleDeMedicamentos.ConsoleApp.Utilidades;

namespace ControleDeMedicamentos.ConsoleApp.ModuloFornecedores;

public class TelaFornecedor : TelaBase<Fornecedor>, ITelaOpcoes, ITelaCrud
{
    public TelaFornecedor(IRepositorio<Fornecedor> repositorio) : base("Fornecedor", repositorio)
    {
    }

    public override void VisualizarTodos(bool deveExibirCabecalho)
    {
        if (deveExibirCabecalho)
            ExibirCabecalho("Visualização de Fornecedores");

        List<Fornecedor> fornecedores = repositorio.SelecionarTodos();

        if (fornecedores.Count == 0)
        {
            Notificador.ExibirMensagem("Nenhum fornecedor registrado.");
            return;
        }

        Console.WriteLine(
            "{0, -7} | {1, -30} | {2, -15} | {3, -20}",
            "Id", "Nome", "Telefone", "CNPJ"
        );

        foreach (Fornecedor f in fornecedores)
        {
            Console.WriteLine(
                "{0, -7} | {1, -30} | {2, -15} | {3, -20}",
                f.Id, f.Nome, f.Telefone, f.Cnpj
            );
        }

        Console.WriteLine("---------------------------------");
        Console.WriteLine("Pressione Enter para voltar ao menu...");
        Console.ReadLine();        
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
