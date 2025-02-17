using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserScreens;

public class CreateRoleScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Criar um novo perfil");
        Console.WriteLine("--------------------");
        Console.WriteLine();
        Console.Write("Digite um nome: ");
        var name = Console.ReadLine();
        Console.Write("Digite uma slug: ");
        var slug = Console.ReadLine();
        
        Create(new Role()
        {
            Name = name,
            Slug = slug
        });

        Console.ReadKey();
        MenuRoleScreen.Load();

    }

    public static void Create(Role role)
    {
        try
        {
            var repository = new Repository<Role>(Database.Connection);
            repository.Create(role);
            Console.WriteLine("Perfil Criado com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao criar um novo perfil");
            Console.WriteLine(ex.Message);
        }
    }
}