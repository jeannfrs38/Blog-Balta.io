using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens;

public class ListTagScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Lista de Tags");
        Console.WriteLine("---------------");
        Console.WriteLine();
        List();
        Console.WriteLine();
        Console.ReadKey();
        MenuTagScreen.Load();
    }

    public static void List()
    {
        var repository = new Repository<Tag>(Database.Connection);
        var tags = repository.Get();

        foreach (var tag in tags)
        {
            Console.WriteLine($"{tag.Id} - {tag.Name}");
        }
    }
}