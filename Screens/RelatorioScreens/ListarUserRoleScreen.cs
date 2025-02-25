using Blog.Repositories;

namespace Blog.Screens.RelatorioScreens;

public class ListarUserRoleScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Listar Usuarios com seus perfis");
        Console.WriteLine("-------------------------------");
        List();
        Console.ReadKey();
        MenuRelatorioScreen.Load();
    }

    public static void List()
    {
        var userRepository = new UserRepository(Database.Connection);
        var users = userRepository.GetWithRoles();

        foreach (var user in users )
        {
            foreach (var role  in user.Roles)
            {
                Console.WriteLine($"{user.Id} - {user.Name}, {user.Email}, HASH, {user.Bio}, {user.Image}, {user.Slug}, {role.Name}, {role.Slug}");
            }
            
        }
    
    }
}