using System;
using System.Linq.Expressions;
using Blog.Models;
using Blog.Repositories;
using Blog.Screens;
using Blog.Screens.CatagoryScreens;
using Blog.Screens.LinkScreens;
using Blog.Screens.PostScreens;
using Blog.Screens.TagScreens;
using Blog.Screens.UserScreens;
using Dapper;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;


namespace Blog
{
    public class Program
    {
        const string CONNECTION_STRING = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$;TrustServerCertificate=True";
        const string CONNECTION_STRING2 = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=Jfr@435#189; TrustServerCertificate=true";
        public static void Main(string[] args)
        {
           Database.Connection = new SqlConnection(CONNECTION_STRING);
           Database.Connection.Open();
            //Desafio
            Load();
            Console.ReadKey();
            //Read All
            //ReadUsers(connection);
            //ReadUsersWithRoles(Database.Connection);
            //ReadRoles(connection);
            //ReadTags(connection);
            //ReadOne
            //ReadUser(connection);
            //ReadRole(connection);
            //ReadTag(connection);
          //Create/Insert
            //CreateUser(connection);
            //CreateRole(connection);
            //CreateTag(connection);
         // Update   
            //UpdateUser(connection);
            //UpdateRole(connection);
            //UpdateTag(connection);
         //Delete   
            //DeleteUser(connection);
            //DeleteRole(connection);
            //DeleteTag(connection);
            Database.Connection.Close();

        }
        
        //Desafio
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Meu Blog");
            Console.WriteLine("-----------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("-----------------");
            Console.WriteLine("1 - Gestao de Usuário");
            Console.WriteLine("2 - Gestao de Perfil");
            Console.WriteLine("3 - Gestao de Categoria");
            Console.WriteLine("4 - Gestao de tag");
            Console.WriteLine("5 - Gestao de Post");
            Console.WriteLine("6 - Vincular perfil/usuário");
            Console.WriteLine("7 - Vincular post/tag");
            Console.WriteLine("8 - Relatorios");
            Console.WriteLine("9 - Sair");
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine()!);
            switch (option)
            {
                case 1:
                    MenuUserScreen.Load();
                    break;
                case 2:
                    MenuRoleScreen.Load();
                    break;
                case 3:
                    MenuCategoryScreen.Load();
                    break;
                case 4:
                    MenuTagScreen.Load();
                    break;
                case 5:
                    MenuPostScreen.Load();
                    break;
                case 6:
                    UserRoleScreen.Load();
                    break;
                case 7:
                    PostTagScreen.Load();
                    break;
                case 8:
                    break;
                case 9:
                    Console.WriteLine("Obrigado ate a proxima!  ");
                    Environment.Exit(0);
                    break;
                default: Load();
                    break;
            }
        }
        //ReadAll
        // public static void ReadUsers(SqlConnection connection)
        // {
        //     var repository = new Repository<User>(connection);
        //     var users = repository.Get();
        //
        //     foreach (var user in users)
        //     {
        //         Console.WriteLine($"{user.Name}");
        //         
        //     }
        // }
        // public static void ReadUsersWithRoles(SqlConnection connection)
        // {
        //     var repository = new UserRepository(connection);
        //     var users = repository.GetWithRoles();
        //
        //     foreach (var user in users)
        //     {
        //         //Console.WriteLine($"{user.Email}");
        //         foreach (var roles in user.Roles)
        //         {
        //             Console.WriteLine($"{user.Email} , {roles.Name} , {roles.Slug}");
        //         }
        //     }
        // }
        //
        // public static void ReadRoles(SqlConnection connection)
        // {
        //     var repository = new Repository<Role>(connection);
        //     var roles =  repository.Get();
        //
        //     foreach (var role in roles)
        //     {
        //         Console.WriteLine($"{role.Name}");
        //     }
        // }
        //
        // public static void ReadTags(SqlConnection connection)
        // {
        //     var repository = new Repository<Tag>(connection);
        //     var tags = repository.Get();
        //
        //     foreach (var tag in tags)
        //     {
        //         Console.WriteLine($"{tag.Name}");
        //     }
        // }
        // //ReadOne 
        // public static void ReadUser(SqlConnection connection)
        // {
        //     var repository = new Repository<User>(connection);
        //     var users = repository.Get(1);
        //     Console.WriteLine($"{users.Slug}");
        // }
        //
        // public static void ReadRole(SqlConnection connection)
        // {
        //     var repository = new Repository<Role>(connection);
        //     var roles = repository.Get(1);
        //     
        //     Console.WriteLine($"{roles.Slug}");
        // }
        //
        // public static void ReadTag(SqlConnection connection)
        // {
        //     var repository = new Repository<Tag>(connection);
        //     var tag = repository.Get(1);
        //
        //     Console.WriteLine($"{tag.Slug}");
        // }
        // //Create And Insert
        // public static void CreateUser(SqlConnection connection)
        // {
        //     var user =  new User()
        //         {
        //             Name = "Samia Anjos",
        //             Email = "samia200ss@gmail.com",
        //             PassWordHash = "HASH",
        //             Bio = "Assistente de Rh",
        //             Image = "http://",
        //             Slug = "samia-anjos"
        //         };
        //
        //         var repository = new Repository<User>(connection);
        //         repository.Create(user);
        //         Console.WriteLine("Cadastro realizado com sucesso");
        //         
        //     
        // }
        //
        // public static void CreateRole(SqlConnection connection)
        // {
        //     var role = new Role()
        //     {
        //         Name = "Administrador",
        //         Slug = "admin",
        //
        //     };
        //     var repository = new Repository<Role>(connection);
        //     repository.Create(role);
        //     Console.WriteLine("Cadastro de Role realizado com sucesso");
        // }
        //
        // public static void CreateTag(SqlConnection connection)
        // {
        //     var tag = new Tag()
        //     {
        //         Name = "Backend CSharp",
        //         Slug = "backend-csharp"
        //         
        //     };
        //
        //     var repository = new Repository<Tag>(connection);
        //     repository.Create(tag);
        //     
        //     Console.WriteLine("Cadastro de Tag realizado com sucesso");
        // }
        //
        // //Update
        //
        // public static void UpdateUser(SqlConnection connection)
        // {
        //     var user =  new User()
        //         {
        //             Id = 2,
        //             Name = "Samia Anjos",
        //             Email = "samia200ss@gmail.com",
        //             PassWordHash = "HASH",
        //             Bio = "Equipe Assistente de Rh",
        //             Image = "http://",
        //             Slug = "samia-anjos-rh"
        //         };
        //     var repository = new Repository<User>(connection);
        //      repository.Update(user);
        //      Console.WriteLine("Atualizacao de user realizada com sucesso");
        //         
        //     
        // }
        //
        // public static void UpdateRole(SqlConnection connection)
        // {
        //     var role = new Role()
        //     {
        //         Id = 2,
        //         Name = "Admin",
        //         Slug ="admin" 
        //     };
        //     var repository = new Repository<Role>(connection);
        //     repository.Update(role);
        //     
        //     Console.WriteLine("Atualizacao de role realizado com sucesso");
        // }
        //
        // public static void UpdateTag(SqlConnection connection)
        // {
        //     var tag = new Tag()
        //     {
        //         Id = 2,
        //         Name = "Backend",
        //         Slug = "backend"
        //     };
        //
        //     var repository = new Repository<Tag>(connection);
        //     repository.Update(tag);
        //     
        //     Console.WriteLine("Atualizacao de tag realizado com sucesso");
        // }
        //
        // public static void DeleteUser(SqlConnection connection)
        // {
        //     
        //     var repository = new Repository<User>(connection);
        //     
        //     var user = repository.Get(1);
        //     repository.Delete(user);
        //     Console.WriteLine("Cadastro excluido com sucesso");
        //         
        // }
        //
        // public static void DeleteRole(SqlConnection connection)
        // {
        //     var repository = new Repository<Role>(connection);
        //     var role = repository.Get(1);
        //     repository.Delete(role);
        //     
        //     Console.WriteLine("Cadastro excluido com sucesso");
        // }
        // public static void DeleteTag(SqlConnection connection)
        // {
        //     var repository = new Repository<Tag>(connection);
        //     var tag = repository.Get(1);
        //     repository.Delete(tag);
        //     
        //     Console.WriteLine("Cadastro excluido com sucesso");
        // }

        
    }
}
