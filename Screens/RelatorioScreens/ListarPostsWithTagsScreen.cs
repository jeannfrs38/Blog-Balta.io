using Blog.Repositories;

namespace Blog.Screens.RelatorioScreens;

public class ListarPostsWithTagsScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Lista de Posts com as Tags");
        Console.WriteLine("--------------------------");
        Console.WriteLine();
        List();
        Console.ReadKey();
        MenuRelatorioScreen.Load();
    }

    public static void List()
    {
        var repository = new PostRepository(Database.Connection);
        var posts = repository.GetPostsWithTags();

        foreach (var post in posts)
        {
            Console.WriteLine($"{post.Id} - {post.Title}");
            Console.WriteLine($"- Tags:");

            foreach (var tag in post.Tags)
            {
                Console.WriteLine($" - {tag.Name}");   
            }
        }


    }
}