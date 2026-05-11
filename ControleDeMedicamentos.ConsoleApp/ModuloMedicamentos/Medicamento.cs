using ControleDeMedicamentos.ConsoleApp.Compartilhado;

namespace ControleDeMedicamentos.ConsoleApp.ModuloMedicamentos;

public class Medicamento : EntidadeBase
{
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public int QuantidadeEstoque { get; set; }
    public Fornecedor Fornecedor { get; set; }

    public Medicamento(string nome, string descricao, int quantidadeEstoque, Fornecedor fornecedor)
    {
        Nome = nome;
        Descricao = descricao;
        QuantidadeEstoque = quantidadeEstoque;
        Fornecedor = fornecedor;
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
