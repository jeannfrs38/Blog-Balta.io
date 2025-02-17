using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens;

public class DeleteTagScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Deletar Tag");
        Console.WriteLine("--------------");
        Console.WriteLine();
        Console.Write("Qual o id da Tag que deseja excluir? ");
        var id = int.Parse(Console.ReadLine());

        Deletar(id);

        Console.ReadKey();
        MenuTagScreen.Load();

    }

    public static void Deletar(int id)
    {
        try
        {
            var repository = new Repository<Tag>(Database.Connection);
            repository.Delete(id);
            Console.WriteLine("Tag excluida com sucesso");
        }
        catch(Exception ex)
        {
            Console.WriteLine("Nao foi possivel excluir a tag");
            Console.WriteLine(ex.Message);
        }
    }
}