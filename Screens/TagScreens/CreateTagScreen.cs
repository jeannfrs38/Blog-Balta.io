using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens;

public class CreateTagScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Criar um tag");
        Console.WriteLine("----------------");
        Console.WriteLine();
        Console.Write("Digite o nome da Tag: ");
        var name = Console.ReadLine();
        
        Console.Write("Digite o Slug da Tag: ");
        var slug = Console.ReadLine();

        Create(new Tag
        {
            Name = name,
            Slug = slug
        });
        Console.ReadKey();
        MenuTagScreen.Load();
    }

    public static void Create(Tag tag)
    {
        try
        {
            var repository = new Repository<Tag>(Database.Connection);
            repository.Create(tag);
            Console.WriteLine("Tag cadastrado com sucesso!");
            
        }
        catch (Exception ex)
        {
            Console.WriteLine("Nao Conseguimos cadastrar a tag");
            Console.WriteLine(ex.Message);
        }


    }
}