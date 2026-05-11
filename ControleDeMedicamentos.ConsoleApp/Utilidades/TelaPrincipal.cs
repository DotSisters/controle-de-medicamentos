using ControleDeMedicamentos.ConsoleApp.Compartilhado;

namespace ControleDeMedicamentos.ConsoleApp.Utilidades;

public class TelaPrincipal
{

  public TelaPrincipal()
  {

  }

  public ITelaOpcoes? ApresentarMenuOpcoesPrincipal()
  {
    Console.Clear();
    Console.WriteLine("---------------------------------");
    Console.WriteLine("Controle de Medicamentos");
    Console.WriteLine("---------------------------------");
    Console.WriteLine("S - Sair");
    Console.WriteLine("---------------------------------");
    Console.Write("> ");
    string? opcaoMenuPrincipal = Console.ReadLine()?.ToUpper();

    return null;
  }
}