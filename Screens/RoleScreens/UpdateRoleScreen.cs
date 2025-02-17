using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.RoleScreens;

public class UpdateRoleScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Atualizar ou Editar Perfil");
        Console.WriteLine("--------------------------");
        Console.Write("Qual o Id do Perfil: ");
        var id = int.Parse(Console.ReadLine());
        Console.Write("Novo nome de Perfil: ");
        var name = Console.ReadLine();
        Console.Write("Novo slug do Perfil: ");
        var slug = Console.ReadLine();

        Update(new Role()
        {
            Id = id,
            Name = name,
            Slug = slug
        });
        Console.ReadKey();
        MenuRoleScreen.Load();
    }

    public static void Update(Role role)
    {
        try
        {
            var repository = new Repository<Role>(Database.Connection);
            repository.Update(role);
            Console.WriteLine("Role atualizada com sucesso!");
            
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao tentar atualizar o perfil");
            Console.WriteLine(ex.Message);
        }
    }
}