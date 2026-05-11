using ControleDeMedicamentos.ConsoleApp.Compartilhado;

namespace ControleDeMedicamentos.ConsoleApp.ModuloPacientes;

public class TelaPaciente : TelaBase<Paciente>, ITelaCrud, ITelaOpcoes
{
  public TelaPaciente(IRepositorio<Paciente> repositorio) : base("Paciente", repositorio)
  {
  }

  public override void VisualizarTodos(bool deveExibirCabecalho)
  {
    throw new NotImplementedException();
  }

  protected override Paciente ObterDadosCadastrais()
  {
    throw new NotImplementedException();
  }
}
