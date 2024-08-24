namespace SistemaCadastroLivros;

public class Funcionario : Pessoa 
{
	public string Cargo { get; set; }
	
	public Funcionario(string nome, string cpf, string cargo) : base(nome, cpf)
	{
		Cargo = cargo;
	}

    public override void ObterIdentificacao()
    {
		Console.WriteLine($"Nome do funcionário: {Nome}, CPF do funcionário: {CPF}, Cargo do funcionário: {Cargo}");
    }
}