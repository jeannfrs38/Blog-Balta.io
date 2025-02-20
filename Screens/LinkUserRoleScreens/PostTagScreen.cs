using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.LinkScreens;

public class PostTagScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Menu Linkar Post e Tag");
        Console.WriteLine("----------------------");
        Console.Write("Qual o Id do Post: ");
        var postId = int.Parse(Console.ReadLine());
        Console.Write("Qual o Id da Tag");
        var tagId = int.Parse(Console.ReadLine());

        CreateLink(new PostTag()
        {
            PostId = postId,
            TagId = tagId
        });
        Console.ReadKey();
        Program.Load();

    }

    public static void CreateLink(PostTag postTag)
    {
        try
        {
            var repository = new Repository<PostTag>(Database.Connection);
            repository.Create(postTag);
            Console.WriteLine("Post vinculado a uma tag com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao tentar vincular um Post a uma tag");
            Console.WriteLine(ex.Message);
        }

    }
}