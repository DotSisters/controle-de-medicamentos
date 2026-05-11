using ControleDeMedicamentos.ConsoleApp.Compartilhado;
using ControleDeMedicamentos.ConsoleApp.Utilidades;

namespace ControleDeMedicamentos.ConsoleApp.ModuloFuncionarios;

public class TelaFuncionario : TelaBase<Funcionario>, ITelaOpcoes, ITelaCrud
{
    public TelaFuncionario(IRepositorio<Funcionario> repositorio) : base("Funcionário", repositorio)
    {
    }
    public override void VisualizarTodos(bool deveExibirCabecalho)
    {
        throw new NotImplementedException();
    }

    protected override Funcionario ObterDadosCadastrais()
    {
        throw new NotImplementedException();
    }
}
