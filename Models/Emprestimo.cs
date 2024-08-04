using System;

namespace Biblioteca;

public class Emprestimo
{
	public int Id { get; set; }
	public int IdCliente { get; set; }
	public int IdLivro { get; set; }
	public DateTime DataDoEmprestimo { get; set; }
	public DateTime DataDevolucaoPrevista { get; set; }
	public DateTime? DataDevolucao { get; set; } // atributo opcional, que pode ser nulo

   
	public override string ToString()
        {
            return $"ID Cliente: {IdCliente}, ID Livro: {IdLivro}, Data do Empréstimo: {DataDoEmprestimo.ToShortDateString()}, Data de Devolução Prevista: {DataDevolucaoPrevista.ToShortDateString()}";
        }
	
}