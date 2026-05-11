using ControleDeMedicamentos.ConsoleApp.Compartilhado;

namespace ControleDeMedicamentos.ConsoleApp.ModuloPacientes;

public class Paciente : EntidadeBase
{
  public string Nome { get; set; }
  public string Telefone { get; set; }
  public string CartaoSUS { get; set; }
  public string CPF { get; set; }

  public Paciente()
  {

  }

  public Paciente(string nome, string telefone, string cartaoSUS, string cpf)
  {
    Nome = nome;
    Telefone = telefone;
    CartaoSUS = cartaoSUS;
    CPF = cpf;
  }

  public override List<string> Validar()
  {
    throw new NotImplementedException();
  }

  public override void AtualizarDados(EntidadeBase entidadeAtualizada)
  {
    throw new NotImplementedException();
  }
}
