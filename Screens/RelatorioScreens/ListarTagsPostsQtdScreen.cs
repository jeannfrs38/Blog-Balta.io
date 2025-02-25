using Blog.Repositories;

namespace Blog.Screens.RelatorioScreens;

public class ListarTagsPostsQtdScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Lista de Tags com quantidade de posts");
        Console.WriteLine("-----------------------------------");
        List();
        Console.ReadKey();
        MenuRelatorioScreen.Load();
        
    }

    public static void List()
    {
        var repository = new TagRepository(Database.Connection);
        var tags = repository.GetTagsWithPosts();

        foreach (var tag in tags)
        {
            Console.WriteLine($"{tag.Id} - {tag.Name} - Posts: {tag.Posts.Count}");
        }
    }
}