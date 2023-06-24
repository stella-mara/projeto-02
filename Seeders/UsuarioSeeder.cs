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
                           NomeCommpleto = "Maria Santos",
                           Genero = "Feminino",
                           DataNascimento = new DateTime(1985, 9, 20),
                           CpfCnpj = "987.654.321-00",
                           Telefone = "(11) 9876-5432",
                           Email = "maria.santos@example.com",
                           TipoUsuario = TipoUsuario.Outro,
                           Status = Status.Ativo
                       },
                       // Adicione mais usuários aqui, se necessário
                   };



               _context.Usuarios.AddRange(usuarios);
               _context.SaveChanges();
           }
       }
   }
}
