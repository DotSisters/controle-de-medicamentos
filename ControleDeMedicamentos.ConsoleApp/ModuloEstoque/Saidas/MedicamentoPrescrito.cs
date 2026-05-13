using ControleDeMedicamentos.ConsoleApp.ModuloMedicamentos;

namespace ControleDeMedicamentos.ConsoleApp.ModuloEstoque.Saidas;

public class MedicamentoPrescrito
{
  public Medicamento Medicamento { get; set; } = null!;
  public uint Quantidade { get; set; } = 0;

  public MedicamentoPrescrito()
  {
  }

  public MedicamentoPrescrito(Medicamento medicamento, uint quantidade) : this()
  {
    Medicamento = medicamento;
    Quantidade = quantidade;
  }
}
