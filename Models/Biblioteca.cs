using System;
using System.Collections.Generic;

namespace Biblioteca;

public class Biblioteca
{
	public List<Cliente> clientes = new List<Cliente>();
	public List<Livro> livros= new List<Livro>();
	public static List<Emprestimo> emprestimos= new List<Emprestimo>();

	public List<Funcionario> funcionarios= new List<Funcionario>();
	
	public static void EmprestarLivro(int idcliente, int idlivro, DateTime diaemprestimo, DateTime devolucaoprevista)
	{
		Emprestimo NovoEmprestimo = new Emprestimo(){

			IdCliente= idcliente,
			IdLivro = idlivro,
			DataDoEmprestimo = diaemprestimo,
			DataDevolucaoPrevista = devolucaoprevista
			};
			
			emprestimos.Add(NovoEmprestimo);
			
			Console.WriteLine("Emprestimo Realizado com sucesso");
	}
	
	public static void VerificarEmprestimos(){

		Console.WriteLine("Emprestimos ativos :");

		if (emprestimos.Count == 0)
		{
			Console.WriteLine("Nenhum emprestimo ativo.");
		}

		else
		{
			//listar os emprestimos
			foreach (var emprestimo in emprestimos)
			{
				Console.WriteLine(emprestimo.ToString());
			}
		}
	}

	
	
	public static void DevolverLivro(int idcliente, int idlivro)
	{	
			var devolver = emprestimos.FirstOrDefault(e => e.IdCliente == idcliente && e.IdLivro == idlivro);//verifica se o id fornecido existe na lista
		emprestimos.Remove(devolver);

		Console.WriteLine("Livro Devolvido com sucesso.");
	}	
}