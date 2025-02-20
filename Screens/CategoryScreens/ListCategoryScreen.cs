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
        Console.WriteLine("1 - Listar Categorias");
        Console.WriteLine("2 - Listar Categorias com Quantidade de Posts");
        var option = int.Parse(Console.ReadLine());

        switch (option)
        {
            case 1:
                List();
                break;
            case 2:
                ListCategoryWithPosts();
                break;
        }

        
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

    public static void ListCategoryWithPosts()
    {
        var categoryRepository = new CategoryRepository(Database.Connection);
        var categories = categoryRepository.GetCategoryWhitPost();

        foreach (var category in categories)
        {
            Console.WriteLine($"{category.Id} - {category.Title} = Quantidade de Posts = {category.Posts.Count}");
        }

    }
}