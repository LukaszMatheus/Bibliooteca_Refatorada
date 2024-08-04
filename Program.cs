using System;
using System.Data.Common;
using System.Runtime.InteropServices.Marshalling;

namespace Biblioteca;

class Program
{
	public static void Main(string[] args)
	{
		Biblioteca biblioteca = new Biblioteca();
	

		int op = 1;
		int alternativa = 0;
		while (op != 0)
		{

			Console.WriteLine("Selecione uma opção: ");

			Console.WriteLine("1 Para abrir menu Clientes.");

			Console.WriteLine("2 Para abrir menu de Funcionários.");

			Console.WriteLine("3 Para abrir menu de livros.");

			Console.WriteLine("4 Empréstimos ");


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
				{
					Console.Clear();
					Console.WriteLine("Digite o Id do cliente a ser excluido");
					int idremovido = Int32.Parse(Console.ReadLine());
					Cliente.RemoverCliente(idremovido);
				}
			}
			else if (op == 2)
			{
				Console.Clear();
				Console.WriteLine("1 Para listar os funcionários: ");
				Console.WriteLine("2 Para adicionar um funcionário :");
				Console.WriteLine("3 Para remover um funcionário. ");
				
				alternativa = Int32.Parse(Console.ReadLine());

				if (alternativa == 1)
				{
					Console.Clear();
					Funcionario.ListarFuncionarios();
				}

				else if (alternativa == 2)
				{

					Console.Clear();

					Console.WriteLine("Digite o nome do funcionário");
					string nome = Console.ReadLine();

					Console.WriteLine("Digite o cargo do funcionário");
					string cargo = Console.ReadLine();

					Console.WriteLine("Digite a data de Admissão");
					DateTime dataadmissao = DateTime.Parse(Console.ReadLine());

					Funcionario.AdicionarFuncionario(nome, cargo, dataadmissao);

				}

				else if (alternativa == 3){

					Console.Clear();
					Console.WriteLine("Digite o id do funcionários a ser removido :");
					var idpararemover = Int32.Parse(Console.ReadLine());
					Funcionario.RemoverFuncionario(idpararemover);
				}
			}

			else if(op == 3){

				Console.Clear();
				Console.WriteLine("1 para ver todos os livros ");
				Console.WriteLine("2 para adicionar um livro");
				alternativa=Int32.Parse(Console.ReadLine());

				if(alternativa == 1){

					Console.Clear();
					Livro.ListarLivros();
				}

				else if(alternativa == 2){

					Console.Clear();
					Console.WriteLine("Digite o titulo do livro ");
					string titulo = Console.ReadLine();
					
					Console.WriteLine("Digite o Autor do livro");
					string autor = Console.ReadLine();

					Livro.AdicionarLivro(titulo, autor);

				}
			}

	        else if (op == 4){

				Console.Clear();
				Console.WriteLine("1-Realizar um empréstimo ");
				Console.WriteLine("2-Devolver um empréstimo");
				Console.WriteLine("3-Verificar emprestimos ativos");
				alternativa = Int32.Parse(Console.ReadLine());

				if (alternativa == 1){

					Console.WriteLine("Digite o ID do cliente: ");
					int idCliente = Int32.Parse(Console.ReadLine());

					Console.WriteLine("Digite o ID do Livro a ser emprestado ");
					int IdLivro=Int32.Parse(Console.ReadLine());

					DateTime diaemprestimo = DateTime.Now;
					DateTime devolucaoprevista = DateTime.Now.AddDays(15);

					Biblioteca.EmprestarLivro(idCliente, IdLivro, diaemprestimo, devolucaoprevista);

				}

				else if (alternativa == 2)
				{
					Console.Clear();
					Console.WriteLine("Digite o Id do cliente ");
					int idcliente=Int32.Parse(Console.ReadLine());

					Console.WriteLine("Digite o Id do livro que o cliente emprestou");
					int idlivro = Int32.Parse(Console.ReadLine());

					Biblioteca.DevolverLivro(idcliente, idlivro);


				}

				else if (alternativa == 3)
				{
					Console.Clear();
					Biblioteca.VerificarEmprestimos();
					

				}


				
			
		}
		}

		



	}
}

