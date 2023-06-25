using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projeto_02.Database;
using projeto_02.Models;
using projeto_02.Models.Enum;


namespace projeto_02.Seeders
{
   public interface IUsuariosSeeder
   {
       void SeedUsuarios();
   }

   public class UsuariosSeeder : IUsuariosSeeder
   {
       private readonly FashionContext _context;

       public UsuariosSeeder(FashionContext context)
       {
           _context = context;
       }

       public void SeedUsuarios()
       {
           if (!_context.Usuarios.Any())
           {
               var usuarios = new List<Usuario>
                   {
                       new Usuario
                       {
                           NomeCommpleto = "João Silva",
                           Genero = "Masculino",
                           DataNascimento = new DateTime(1990, 5, 15),
                           CpfCnpj = "123.456.789-00",
                           Telefone = "(11) 1234-5678",
                           Email = "joao.silva@example.com",
                           TipoUsuario = TipoUsuario.Administrador,
                           Status = Status.Ativo
                       },
                       new Usuario
                       {
                           NomeCommpleto = "Maria Almeida",
                           Genero = "Feminino",
                           DataNascimento = new DateTime(1985, 12, 20),
                           CpfCnpj = "987.678.321-00",
                           Telefone = "(11) 9876-5411",
                           Email = "maria.almeida@example.com",
                           TipoUsuario = TipoUsuario.Outro,
                           Status = Status.Ativo
                       },
                        new Usuario
                       {
                           NomeCommpleto = "João Silva",
                           Genero = "asculino",
                           DataNascimento = new DateTime(1985, 1, 20),
                           CpfCnpj = "105.654.321-00",
                           Telefone = "(11) 9899-5432",
                           Email = "joao.silva@example.com",
                           TipoUsuario = TipoUsuario.Outro,
                           Status = Status.Ativo
                       },                       
                       new Usuario
                       {
                          NomeCommpleto = "Henrique José",
                          Genero = "Masculino",
                          DataNascimento = new DateTime(1980, 12, 31),
                          CpfCnpj = "002.654.987-00",
                          Telefone = "(00) 3210-9866"
                          Email = "henrique.jose@example.com",
                          TipoUsuario = TipoUsuario.Outro,
                          Status = Status.Ativo
                       },                       
                       new Usuario
                       {
                           NomeCommpleto = "Luiza Santos",
                           Genero = "Feminino",
                           DataNascimento = new DateTime(1982, 9, 20),
                           CpfCnpj = "987.654.987-00",
                           Telefone = "(11) 9976-5432",
                           Email = "luiza.santos@example.com",
                           TipoUsuario = TipoUsuario.Outro,
                           Status = Status.Ativo
                       },
                   };

               _context.Usuarios.AddRange(usuarios);
               _context.SaveChanges();
           }
       }
   }
}
