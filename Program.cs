using System;
using System.Runtime.InteropServices.Marshalling;

namespace Biblioteca;

class Program
{
	public static void Main(string[] args)
	{
		Biblioteca biblioteca = new Biblioteca();










		// adicionar livro
		biblioteca.livros.Add(new Livro
		{
			Id = 1,
			Titulo = "Dom Casmurro",
			Autor = "Machado de Assis",
			Disponivel = true
		});

		// Emprestar livro
		biblioteca.EmprestarLivro(1, 1);
		biblioteca.DevolverLivro(1, 1);
		biblioteca.EmprestarLivro(1, 2);

		/*static void IniciarBiblioteca(Biblioteca biblioteca)
		{
			biblioteca.EmprestarLivro(2,2);
		}*/

		int op = 1;
		int alternativa = 0;
		while (op != 0)
		{

			Console.WriteLine("Selecione uma opção: ");

			Console.WriteLine("1 Para abrir aba Clientes.");

			Console.WriteLine("2 Para abrir menu de Funcionários.");
			op = int.Parse(Console.ReadLine());

			if (op == 0)
			{
				break;
			}

			else if (op == 1)
			{

				Console.Clear();

				Console.WriteLine("1 - Listar um Cliente: ");
				Console.WriteLine("2 - Cadastrar um Cliente: ");
				Console.WriteLine("3 - Apagar um Cliente: ");
				alternativa = Int32.Parse(Console.ReadLine());

				if (alternativa == 1)
				{
					Console.Clear();
					Cliente.ListarClientes();
				}

				else if (alternativa == 2)
				{
					Console.Clear();
					Console.WriteLine("Digite o nome do cliente:");
					string nome = Console.ReadLine();
					Console.WriteLine("Digite a data de nascimento (ano/mês/dia):");
					DateTime dataNascimento = DateTime.Parse(Console.ReadLine());
					Console.WriteLine("Digite o telefone do cliente:");
					string telefone = Console.ReadLine();

					Cliente.CadastrarCliente(nome, dataNascimento, telefone);
				}
				else if (alternativa == 3)
				{	Console.Clear();
					Console.WriteLine("Digite o Id do cliente a ser excluido");
					int idremovido = Int32.Parse(Console.ReadLine());
					Cliente.RemoverCliente(idremovido);
				}
			}
			else if (op == 2)
			{
				Console.Clear();
				Console.WriteLine("2 - Listar Funcionarios: ");
				Console.ReadKey();
			}
		}



	}
}

