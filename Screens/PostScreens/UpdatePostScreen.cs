using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.PostScreens;

public class UpdatePostScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Atualizar posts cadatrados por blog");
        Console.WriteLine("-----------------------------------");
        Console.WriteLine();
        Console.WriteLine("Qual o Id do post: ");
        var id = int.Parse(Console.ReadLine());
        Console.Write("Novo Author: ");
        var authorId = int.Parse(Console.ReadLine());
        Console.Write("Nova Categoria: ");
        var categoryId = int.Parse(Console.ReadLine());
        Console.Write("Novo Title: ");
        var title = Console.ReadLine();
        Console.Write("Novo Summary: ");
        var summary = Console.ReadLine();
        Console.Write("Novo Body: ");
        var body = Console.ReadLine();
        Console.Write("Novo Slug: ");
        var slug = Console.ReadLine();
        var createDate = DateTime.Now;
        var lastDate = DateTime.Now;

        Update(new Post()
        {
            Id = id,
            AuthorId = authorId,
            CategoryId = categoryId,
            Title = title,
            Summary = summary,
            Body = body,
            Slug = slug,
            CreateDate = createDate,
            LastUpdateDate = lastDate
        });

        Console.ReadKey();
        MenuPostScreen.Load();
    }

    public static void Update(Post post)
    {
        try
        {
            var repository = new Repository<Post>(Database.Connection);
            repository.Update(post);
            Console.WriteLine("Post atualizado com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao tentar atualizar o post");
            Console.WriteLine(ex.Message);
        }
    }
}