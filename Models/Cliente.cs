using System;
using System.Net.WebSockets;
using System.Collections.Generic;
using System.Data.Common;
using System.Collections.Specialized;

namespace Biblioteca;

public class Cliente : Pessoa
{
	public int Id { get; set; }
	public string Telefone { get; set; }

	List<Cliente> clientes = new List<Cliente>()
	{
		new Cliente {Id=1, Nome="Lucas",DataNascimento=new DateTime(2004, 06, 01), Telefone="42988776655"}
	};

	public static void ListarClientes(List<Cliente> clientes)
	{	
		{
            Console.WriteLine("Clientes Cadastrados:");
            foreach (var cliente in clientes)
            {
                Console.WriteLine(cliente);
            }
        }
	}
	


}