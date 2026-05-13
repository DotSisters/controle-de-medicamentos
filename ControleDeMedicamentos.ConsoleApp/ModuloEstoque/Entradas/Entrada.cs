using ControleDeMedicamentos.ConsoleApp.Compartilhado;
using ControleDeMedicamentos.ConsoleApp.ModuloFuncionarios;
using ControleDeMedicamentos.ConsoleApp.ModuloMedicamentos;

namespace ControleDeMedicamentos.ConsoleApp.ModuloEstoque.Entradas;

public class Entrada
{
  public DateTime Data { get; set; }
  public Medicamento Medicamento { get; set; }
  public Funcionario Funcionario { get; set; }
  public uint Quantidade { get; set; } = 0;
  public Entrada()
  {

  }

  public Entrada(Medicamento medicamento, Funcionario funcionario, uint quantidade) : this()
  {
    Data = DateTime.Now;
    Medicamento = medicamento;
    Funcionario = funcionario;
    Quantidade = quantidade;

    // Medicamento.RegistrarRequisicaoEntrada(this);
  }
}
