using Blog.Repositories;

namespace Blog.Screens.RelatorioScreens;

public class ListarPostsWithCategoriaScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Lista de Posts com sua Categoria");
        Console.WriteLine("--------------------------------");
        Console.WriteLine();
        List();
        Console.ReadKey();
        MenuRelatorioScreen.Load();
    }

    public static void List()
    {
        var repository = new PostRepository(Database.Connection);
        var posts = repository.GetPostWithCategory();

        foreach (var post in posts)
        {
            Console.WriteLine($"{post.Id} - {post.Title} - {post.Summary} - Categoria: {post.CategoryId} - {post.Category.Title} - {post.Category.Slug}");
        }
    }
}