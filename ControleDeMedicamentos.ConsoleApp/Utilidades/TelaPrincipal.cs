using ControleDeMedicamentos.ConsoleApp.Compartilhado;
using ControleDeMedicamentos.ConsoleApp.ModuloFornecedores;
using ControleDeMedicamentos.ConsoleApp.ModuloPacientes;
using ControleDeMedicamentos.ConsoleApp.ModuloMedicamentos;

namespace ControleDeMedicamentos.ConsoleApp.Utilidades;

public class TelaPrincipal
{
  private readonly IRepositorio<Fornecedor> repositorioFornecedor;
  private readonly IRepositorio<Paciente> repositorioPaciente;

  private readonly IRepositorio<Medicamento> repositorioMedicamento;

  public TelaPrincipal(IRepositorio<Fornecedor> repositorioFornecedor, IRepositorio<Paciente> repositorioPaciente, IRepositorio<Medicamento> repositorioMedicamento)
  {
    this.repositorioFornecedor = repositorioFornecedor;
    this.repositorioPaciente = repositorioPaciente;
    this.repositorioMedicamento = repositorioMedicamento;
  }

  public ITelaOpcoes? ApresentarMenuOpcoesPrincipal()
  {
    Console.Clear();
    Console.WriteLine("---------------------------------");
    Console.WriteLine("Controle de Medicamentos");
    Console.WriteLine("---------------------------------");
    Console.WriteLine("1 - Gestão de Fornecedores");
    Console.WriteLine("2 - Gestão de Pacientes");
    Console.WriteLine("3 - Gestão de Medicamentos");
    Console.WriteLine("S - Sair");
    Console.WriteLine("---------------------------------");
    Console.Write("> ");
    string? opcaoMenuPrincipal = Console.ReadLine()?.ToUpper();

    if (opcaoMenuPrincipal == "1")
      return new TelaFornecedor(repositorioFornecedor);

    if (opcaoMenuPrincipal == "2")
      return new TelaPaciente(repositorioPaciente);

    if (opcaoMenuPrincipal == "3")
      return new TelaMedicamento(repositorioMedicamento, repositorioFornecedor);

    return null;
  }
}