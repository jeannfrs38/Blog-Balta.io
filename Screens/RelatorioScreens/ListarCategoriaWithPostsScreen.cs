using Blog.Repositories;

namespace Blog.Screens.RelatorioScreens;

public class ListarCategoriaWithPostsScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Lista de Posts de uma Categoria");
        Console.WriteLine("-----------------------------");
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
            Console.WriteLine($"{category.Id} - {category.Title}");
            Console.WriteLine($"- Posts");
            foreach (var post in category.Posts)
            {
                
                Console.WriteLine($" - {post.Title} ");
            }

            
        }
    }
}