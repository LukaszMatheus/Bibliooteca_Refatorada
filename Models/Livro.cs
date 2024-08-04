using System;
using System.Collections.Generic;
namespace Biblioteca;

public class Livro
{
	public int IdLivro { get; set; }
	public string Titulo { get; set; }
	public string Autor { get; set; }
	public bool Disponivel { get; set; }

	public static List<Livro> livros = new List<Livro>{

	new Livro {IdLivro = 1, Titulo = "Pai pobre pai rico", Autor="Robert Kyiosaki", Disponivel=true}

	};

	public static void ListarLivros()
	{

		Console.WriteLine("Livros Cadastrados na biblioteca :");

		if (livros.Count == 0)
		{
			Console.WriteLine("Nenhum livro cadastrado.");
		}

		else
		{
			//listar os livros da lista
			foreach (var livro in livros)
			{
				Console.WriteLine(livro.ToString());
			}
		}
	}

	public static void AdicionarLivro(string titulo, string autor){
		int novoId = livros.Count > 0 ? livros[^1].IdLivro + 1 : 1;
		Livro novoLivro = new Livro
		{
			IdLivro = novoId,
			Titulo=titulo,
			Autor=autor,
			Disponivel=true
		};
	livros.Add(novoLivro);
	Console.WriteLine("Livro adicionado com sucesso!" );

	}
	public override string ToString() //formatação da saída de função ListarLivros
	{
		return $"ID: {IdLivro}, Título: {Titulo}, Autor: {Autor}, Disponivel : {Disponivel}";
	}

}