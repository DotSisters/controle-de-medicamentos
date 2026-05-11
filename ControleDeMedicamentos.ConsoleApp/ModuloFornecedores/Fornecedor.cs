
using ControleDeMedicamentos.ConsoleApp.Compartilhado;

public class Fornecedor : EntidadeBase
{
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public string Cnpj { get; set; }

    public Fornecedor()
    {
    }
    public Fornecedor(string nome, string telefone, string cnpj)
    {
        Nome = nome;
        Telefone = telefone;
        Cnpj = cnpj;
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