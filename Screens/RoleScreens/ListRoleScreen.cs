using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.RoleScreens;

public class ListRoleScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Listar perfis cadastrados");
        Console.WriteLine("-------------------------");
        Console.WriteLine();
        List();
        Console.ReadKey();
        MenuRoleScreen.Load();
    }

    public static void List()
    {
        var repository = new Repository<Role>(Database.Connection);
        var roles = repository.Get();

        foreach (var role in roles)
        {
            Console.WriteLine($"{role.Id} - {role.Name}, {role.Slug}");
        }
    }
}