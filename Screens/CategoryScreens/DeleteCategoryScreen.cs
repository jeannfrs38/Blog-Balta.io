using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.CatagoryScreens;

public class DeleteCategoryScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Excluir uma Categoria");
        Console.WriteLine("---------------------");
        Console.WriteLine();
        Console.WriteLine("Qual o Id da categoria: ");
        var id = int.Parse(Console.ReadLine());
        
        Delete(id);

        Console.ReadKey();
        MenuCategoryScreen.Load();
    }

    public static void Delete(int id)
    {
        try
        {
            var repository = new Repository<Category>(Database.Connection);
            repository.Delete(id);
            Console.WriteLine("Categoria foi Excluida com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao tentar excluir uma categoria");
            Console.WriteLine(ex.Message);
        }

        
    }
}