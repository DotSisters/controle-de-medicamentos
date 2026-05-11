using System;
using ControleDeMedicamentos.ConsoleApp.Compartilhado;
using ControleDeMedicamentos.ConsoleApp.ModuloFornecedores;
using ControleDeMedicamentos.ConsoleApp.Utilidades;

namespace ControleDeMedicamentos.ConsoleApp.ModuloMedicamentos;

public class TelaMedicamento : TelaBase<Medicamento>, ITelaOpcoes, ITelaCrud
{

    public TelaMedicamento(IRepositorio<Medicamento> repositorio, IRepositorio<Fornecedor> repositorioFornecedor) : base("Medicamento", repositorio)
    {
        
    }

    public override void VisualizarTodos(bool deveExibirCabecalho)
    {
        throw new NotImplementedException();
    }

    protected override Medicamento ObterDadosCadastrais()
    {
        throw new NotImplementedException();
    }
}
