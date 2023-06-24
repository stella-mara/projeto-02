using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projeto_02.Database;
using projeto_02.Models;

namespace projeto_02.Seeders
{
  public static class PessoaSeeder
  {
    public static void Seed(FashionContext context)
    {
      var pessoa1 = new Pessoa
      {
        NomeCommpleto = "José de Almeida",
        Genero = "Masculino",
        DataNascimento = new DateTime(1990, 5, 15),
        CpfCnpj = "123.456.789-00",
        Telefone = "(00) 1234-5678"
      };

      var pessoa2 = new Pessoa
      {
        NomeCommpleto = "Alice Ramos",
        Genero = "Feminino",
        DataNascimento = new DateTime(1985, 9, 30),
        CpfCnpj = "987.654.321-00",
        Telefone = "(00) 9876-5432"
      };

      var pessoa3 = new Pessoa
      {
        NomeCommpleto = "Henrique Souza",
        Genero = "Masculino",
        DataNascimento = new DateTime(1995, 2, 10),
        CpfCnpj = "456.789.123-00",
        Telefone = "(00) 4567-8901"
      };

      var pessoa4 = new Pessoa
      {
        NomeCommpleto = "Maria Oliveira",
        Genero = "Feminino",
        DataNascimento = new DateTime(1980, 12, 25),
        CpfCnpj = "321.654.987-00",
        Telefone = "(00) 3210-9876"
      };

      var pessoa5 = new Pessoa
      {
        NomeCommpleto = "João Santos",
        Genero = "Masculino",
        DataNascimento = new DateTime(1998, 7, 5),
        CpfCnpj = "789.123.456-00",
        Telefone = "(00) 7890-1234"
      };

      context.Pessoas.AddRange(pessoa1, pessoa2, pessoa3, pessoa4, pessoa5);

      context.SaveChanges();
    }
  }
}