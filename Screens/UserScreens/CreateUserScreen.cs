using System.Threading.Channels;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserScreens;

public class CreateUserScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Criando novo usuario");
        Console.WriteLine("--------------------");
        Console.Write("Digite seu nome: ");
        var name = Console.ReadLine();
        Console.Write("Digite seu  email: ");
        var email = Console.ReadLine();
        Console.Write("Digite uma senha: ");
        var password = Console.ReadLine();
        Console.Write("Defina voce em poucas palavras: ");
        var bio = Console.ReadLine();
        Console.Write("Uma Imagem sua: ");
        var image = Console.ReadLine();
        Console.Write("seu slug: ");
        var slug = Console.ReadLine();

        Create(new User()
        {
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

    public static void Create(User user)
    {
        try
        {
            var repository = new Repository<User>(Database.Connection);
            repository.Create(user);
            Console.WriteLine("Usuario Criado com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao tentar cria um Usuario!");
            Console.WriteLine(ex.Message);
        }
    }
}