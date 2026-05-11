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
    Console.Write("Digite o nome do paciente: ");
    string nome = Console.ReadLine() ?? string.Empty;

    Console.Write("Digite o telefone do paciente: ");
    string telefone = Console.ReadLine() ?? string.Empty;

    Console.Write("Digite o número do cartão do SUS: ");
    string cartaoSUS = Console.ReadLine() ?? string.Empty;

    Console.Write("Digite o CPF do paciente: ");
    string cpf = Console.ReadLine() ?? string.Empty;

    return new Paciente(nome, telefone, cartaoSUS, cpf);
  }
}
