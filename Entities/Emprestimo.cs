namespace SistemaCadastroLivros;

public class Emprestimo
{
	public Livro Livro { get; private set; }
	public Cliente Cliente { get; private set; }
	public DateTime DataEmprestimo { get; private set; }
	public DateTime DataDevolucao { get; private set; }

	public Emprestimo(Livro livro, Cliente cliente)
	{
		Livro = livro;
		Cliente = cliente;
		DataEmprestimo = DateTime.Now;
		DataDevolucao = DataEmprestimo.AddDays(14);
	}

	public void ConcluirEmprestimo()
	{
		Livro.Emprestar();
		Console.WriteLine($"Emprestimo completo ao cliente {Cliente}. Data de devolução: {DataDevolucao.ToShortDateString()}");
	}

	public void DevolverLivro()
	{
		Livro.Devolver();
		Console.WriteLine($"Livro {Livro} devolvido pelo cliente {Cliente} com sucesso!");
	}
}