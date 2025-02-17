using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserScreens;

public class UpdateUserScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Atualizacao de Usuario");
        Console.WriteLine("----------------------");
        Console.Write("Digite o Id do Usuario: ");
        var id = int.Parse(Console.ReadLine());
        Console.Write("Informe o nome: ");
        var name = Console.ReadLine();
        Console.Write("Informe o email: ");
        var email = Console.ReadLine();
        Console.Write("Informe uma senha:");
        var password = Console.ReadLine();
        Console.Write("Informe a bio:");
        var bio = Console.ReadLine();
        Console.Write("Informe a image: ");
        var image = Console.ReadLine();
        Console.Write("Informe o slug: ");
        var slug = Console.ReadLine();

        Update(new User()
        {
            Id = id,
            Name = name,
            Email = email,
            PassWordHash = password,
            Bio = bio,
            Image = image,
            Slug = slug
        });
        Console.ReadKey();
        MenuUserScreen.Load();
    }

    public static void Update(User user)
    {
        try
        {
            var repository = new Repository<User>(Database.Connection);
            repository.Update(user);
            Console.WriteLine("Usuario atualizado com sucesso! ");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Nao foi possivel atualizar o usuario ");
            Console.WriteLine(ex.Message);
        }
    }
}