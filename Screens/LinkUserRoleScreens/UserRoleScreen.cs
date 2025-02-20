using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.LinkScreens;

public class UserRoleScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Linkar usuario com perfil");
        Console.WriteLine("-------------------------");
        Console.WriteLine();
        Console.Write("Qual o Id do usuario: ");
        var userId = int.Parse(Console.ReadLine());
        Console.WriteLine("Qual o Id do perfil: ");
        var roleId = int.Parse(Console.ReadLine());

        CreateLink(new UserRole()
        {
            UserId = userId,
            RoleId = roleId
        });

        Console.ReadKey();
        Program.Load();
    }

    public static void CreateLink(UserRole userRole)
    {
        try
        {
            var repository = new Repository<UserRole>(Database.Connection);
            repository.Create(userRole);
            Console.WriteLine("Usuario e Perfil Vinculados com sucesso");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao tentar vincular Usuario e Perfil");
            Console.WriteLine(ex.Message);
        }

        
    }
    
}