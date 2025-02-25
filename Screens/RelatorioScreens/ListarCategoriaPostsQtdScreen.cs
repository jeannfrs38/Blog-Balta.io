using System.Threading.Channels;
using Blog.Repositories;

namespace Blog.Screens.RelatorioScreens;

public class ListarCategoriaPostsQtdScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Listar categoria e quantidade de posts");
        Console.WriteLine("--------------------------------------");
        Console.WriteLine();
        List();
        Console.ReadKey();
        MenuRelatorioScreen.Load();

    }

    public static void List()
    {
        var categoryRepository = new CategoryRepository(Database.Connection);
        var categories = categoryRepository.GetCategoryWhitPost();

        foreach (var category in categories)
        {
            Console.WriteLine($"{category.Id} - {category.Title} = Quantidade de Posts = {category.Posts.Count}");
        }
    }
}