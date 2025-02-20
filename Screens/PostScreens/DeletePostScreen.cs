using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.PostScreens;

public class DeletePostScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Excluir Post");
        Console.WriteLine("------------");
        Console.WriteLine();
        Console.WriteLine("Qual o Id do Post: ");
        var id = int.Parse(Console.ReadLine());

        Delete(id);
        Console.ReadKey();
        MenuPostScreen.Load();
    }

    public static void Delete(int id)
    {
        try
        {
            var repository = new Repository<Post>(Database.Connection);
            repository.Delete(id);
            Console.WriteLine("Post excluido com sucesso!");
            
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao tentar excluir Post");
            Console.WriteLine(ex.Message);
            
        }
    }
}