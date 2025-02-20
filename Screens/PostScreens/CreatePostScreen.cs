using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.PostScreens;

public class CreatePostScreen
{
    
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Cria novo Post");
        Console.WriteLine("--------------");
        Console.WriteLine();
        Console.Write("Quem e o Author do Post: ");
        var authorId = int.Parse(Console.ReadLine());
        Console.Write("Qual a Categoria do Post: ");
        var categoryId = int.Parse(Console.ReadLine());
        Console.Write("Qual o Titulo: ");
        var title = Console.ReadLine();
        Console.Write("Qual o Summario: ");
        var summary = Console.ReadLine();
        Console.Write("Qual o conteudo: ");
        var body = Console.ReadLine();
        Console.Write("Qual o slug do post: ");
        var slug = Console.ReadLine();
        var createDate = DateTime.Now;
        var LastUpdate = DateTime.Now;

        Create(new Post()
        {
            AuthorId = authorId,
            CategoryId = categoryId,
            Title = title,
            Summary = summary,
            Body = body,
            Slug = slug,
            CreateDate = createDate,
            LastUpdateDate = LastUpdate
                
        });

        Console.ReadKey();
        MenuPostScreen.Load();
    }

    public static void Create(Post post)
    {
        try
        {
            var repository = new Repository<Post>(Database.Connection);
            repository.Create(post);
            Console.WriteLine("Post cadatrado com sucesso!");
            
            
        }
        catch (Exception ex)
        {
            Console.WriteLine("Nao foi possivel cadastrar o Post");
            Console.WriteLine(ex.Message);
        }
    }
}