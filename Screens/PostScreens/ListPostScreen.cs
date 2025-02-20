using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.PostScreens;

public class ListPostScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Listar posts cadastrados");
        Console.WriteLine("------------------------");
        Console.WriteLine();
        List();
        Console.ReadKey();
        MenuPostScreen.Load();
    }

    public static void List()
    {
        var repository = new Repository<Post>(Database.Connection);
        var  posts = repository.Get();

        foreach (var post in posts)
        {
            Console.WriteLine($"{post.Id} - {post.AuthorId} - {post.CategoryId} - {post.Title}, {post.Summary}, {post.Body}, {post.CreateDate}, {post.LastUpdateDate}");
        }
    }
}