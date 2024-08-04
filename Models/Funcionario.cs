using System;

namespace Biblioteca;

public class Funcionario : Pessoa
{
	public int Id { get; set; }

	public string Nome { get; set; }
	public string Cargo{ get; set; }
	public DateTime DataAdmissao { get; set; }

	public static List <Funcionario> funcionarios = new List<Funcionario>{

		new Funcionario { Id = 1, Nome="Jefferson", Cargo = "Professor", DataAdmissao = new DateTime(2023, 05, 19)}

	};

	public static void ListarFuncionarios(){

		Console.WriteLine("Funcionários Cadastrados:"); //verificação se tem ou não funcionarios
		if (funcionarios.Count == 0)
		{
			Console.WriteLine("Nenhum funcionário cadastrado.");
		}

		else
		{
			//listar os funcionarios da lista
			foreach (var funcionario in funcionarios)
			{
				Console.WriteLine(funcionario.ToString());
			}
		}
	} 

	public override string ToString() //formatação da saída de função ListarClientes
	{
		return $"ID: {Id}, Nome: {Nome}, Cargo: {Cargo}, Data de Admissão: {DataAdmissao.ToShortDateString()}";
	}

    public static void AdicionarFuncionario(string nome, string cargo, DateTime dataadmissao){

		int novoId = funcionarios.Count > 0 ? funcionarios[^1].Id + 1 : 1;
		Funcionario novoFuncionario = new Funcionario{
		
		Id= novoId,
		Nome = nome,
		Cargo = cargo,
		DataAdmissao = dataadmissao


		};
		funcionarios.Add(novoFuncionario);
		Console.WriteLine("Funcionário Cadastrado com sucesso");
	}

	public static void RemoverFuncionario(int idpararemover){
		var funcionariopararemover= funcionarios.FirstOrDefault(funcionario => funcionario.Id == idpararemover);
		funcionarios.Remove(funcionariopararemover);
		Console.WriteLine("Funcionário removido com sucesso.");
		

	}
}

