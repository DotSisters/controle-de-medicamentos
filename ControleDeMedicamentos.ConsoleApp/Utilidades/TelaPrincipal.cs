using ControleDeMedicamentos.ConsoleApp.Compartilhado;
using ControleDeMedicamentos.ConsoleApp.ModuloFornecedores;
using ControleDeMedicamentos.ConsoleApp.ModuloPacientes;

namespace ControleDeMedicamentos.ConsoleApp.Utilidades;

public class TelaPrincipal
{
  private readonly IRepositorio<Fornecedor> repositorioFornecedor;
  private readonly IRepositorio<Paciente> repositorioPaciente;
  public TelaPrincipal(IRepositorio<Fornecedor> repositorioFornecedor, IRepositorio<Paciente> repositorioPaciente)
  {
    this.repositorioFornecedor = repositorioFornecedor;
    this.repositorioPaciente = repositorioPaciente;
  }

  public ITelaOpcoes? ApresentarMenuOpcoesPrincipal()
  {
    Console.Clear();
    Console.WriteLine("---------------------------------");
    Console.WriteLine("Controle de Medicamentos");
    Console.WriteLine("---------------------------------");
    Console.WriteLine("1 - Gestão de Fornecedores");
    Console.WriteLine("2 - Gestão de Pacientes");
    Console.WriteLine("S - Sair");
    Console.WriteLine("---------------------------------");
    Console.Write("> ");
    string? opcaoMenuPrincipal = Console.ReadLine()?.ToUpper();

    if (opcaoMenuPrincipal == "1")
      return new TelaFornecedor(repositorioFornecedor);

    if (opcaoMenuPrincipal == "2")
      return new TelaPaciente(repositorioPaciente);

    return null;
  }
}