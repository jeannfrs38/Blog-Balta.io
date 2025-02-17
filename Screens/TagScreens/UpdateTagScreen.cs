using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens;

public class UpdateTagScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Atualizar tag");
        Console.WriteLine("-----------");
        Console.WriteLine();
        Console.Write("Qual o Id da Tag: ");
        var id = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.Write("Novo nome: ");
        var name = Console.ReadLine();
        Console.Write("Novo slug: ");
        var slug =  Console.ReadLine();
        Update(new Tag()
        {
            Id = id,
            Name = name,
            Slug = slug
        });

        Console.ReadKey();
        MenuTagScreen.Load();



    }

    public static void Update(Tag tag)
    {
        try
        {
            var repository = new Repository<Tag>(Database.Connection);
            repository.Update(tag);
            Console.WriteLine("Tag atualizada com sucesso");
        }
        catch(Exception ex)
        {
            Console.WriteLine("Nao foi possivel Atualizar a Tag");
            Console.WriteLine(ex.Message);
        }
        
    }
}