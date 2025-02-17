using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.CatagoryScreens;

public class CreateCategoryScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Criar uma nova Categoria");
        Console.WriteLine("------------------------");
        Console.WriteLine();
        Console.WriteLine("Digite o nome da categoria: ");
        var title = Console.ReadLine();
        Console.WriteLine("Digite a slug da categoria: ");
        var slug = Console.ReadLine();
        
        Create(new Category()
        {
            Title = title,
            Slug = slug
        });
        Console.ReadKey();
        MenuCategoryScreen.Load();
    }

    public static void Create(Category category)
    {
        try
        {
            var repository = new Repository<Category>(Database.Connection);
            repository.Create(category);
            Console.WriteLine("Categoria criada com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao tentar criar categoria!");
            Console.WriteLine(ex.Message);
        }
    }
}