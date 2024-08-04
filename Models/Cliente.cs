using System;
using System.Net.WebSockets;
using System.Collections.Generic;
using System.Data.Common;
using System.Collections.Specialized;

namespace Biblioteca;

public class Cliente : Pessoa
{
	public int IdCliente { get; set; }
	public string Telefone { get; set; }

	public static List<Cliente> clientes = new List<Cliente>//Lista de clientes e clientes adicionados manualmente
	{
		new Cliente {IdCliente = 1, Nome="Lucas",DataNascimento=new DateTime(2004, 06, 01), Telefone="42988776655"},
		new Cliente {IdCliente = 2, Nome="Jaqueline",DataNascimento=new DateTime(2003, 11, 20), Telefone="4233112233" }
	};

	public static void ListarClientes()
	{
		Console.WriteLine("Clientes Cadastrados:"); //Verifica se tem ou não clientes cadastrados, se tiver manda imprimir na tela com o laço de repetição foreach
		if (clientes.Count == 0)
		{
			Console.WriteLine("Nenhum cliente cadastrado.");
		}

		else
		{
			//Console.WriteLine("Clientes Cadastrados:");
			foreach (var cliente in clientes)
			{
				Console.WriteLine(cliente.ToString());
			}
		}
	}

	public static void CadastrarCliente(string nome, DateTime datanascimento, string telefone)//cadastra os clientes
	{
		int novoId = clientes.Count > 0 ? clientes[^1].IdCliente + 1 : 1;
		Cliente novoCliente = new Cliente
		{

			IdCliente = novoId,
			Nome = nome,
			DataNascimento = datanascimento,
			Telefone = telefone
		};

		clientes.Add(novoCliente);
		Console.WriteLine("CLiente cadastrado com sucesso");
	}

	public static void RemoverCliente(int idremovido) //funcao para remover um cliente
	{
		var clienteParaRemover = clientes.FirstOrDefault(cliente => cliente.IdCliente == idremovido);//verifica se o id fornecido existe na lista
		clientes.Remove(clienteParaRemover);
		Console.WriteLine("Cliente removido com sucesso ");

	}

	public override string ToString() //formatação da saída de função ListarClientes
	{
		return $"ID: {IdCliente}, Nome: {Nome}, Data de Nascimento: {DataNascimento.ToShortDateString()}, Telefone: {Telefone}";
	}



}