namespace SistemaCadastroLivros;

public class Cliente : Pessoa
{
	public string Endereco { get; set; }

	public Cliente(string nome, string cpf, string endereco) : base(nome, cpf)
	{
		Endereco = endereco;
	}

	public override void ObterIdentificacao()
	{
		Console.WriteLine($"Nome do cliente: {Nome}, CPF do cliente: {CPF}, Endereço do cliente: {Endereco}");
	}
}