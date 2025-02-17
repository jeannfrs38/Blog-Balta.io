using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.CatagoryScreens;

public class ListCategoryScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Listar Categorias");
        Console.WriteLine("-----------------");
        Console.WriteLine();
        
        List();
        Console.ReadKey();
        MenuCategoryScreen.Load();
    }

    public static void List()
    {
        var repository = new Repository<Category>(Database.Connection);
        var categories = repository.Get();

        foreach (var category in categories)
        {
            Console.WriteLine($"{category.Id} - {category.Title}, {category.Slug}");
        }
    }
}