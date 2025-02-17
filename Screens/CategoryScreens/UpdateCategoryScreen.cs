using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.CatagoryScreens;

public class UpdateCategoryScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Atualizar Categorias");
        Console.WriteLine("--------------------");
        Console.WriteLine();
        Console.WriteLine("Digite o id da Categoria: ");
        var id = int.Parse(Console.ReadLine());
        Console.WriteLine("Novo titulo: ");
        var title = Console.ReadLine();
        Console.WriteLine("Novo slug: ");
        var slug = Console.ReadLine();
        
        Update(new Category()
        {
            Id = id,
            Title = title,
            Slug = slug
        });
        Console.ReadKey();
        MenuCategoryScreen.Load();
    }

    public static void Update(Category category)
    {
        
        try
        {
            var repository = new Repository<Category>(Database.Connection);
            repository.Update(category);
            Console.WriteLine("Categoria atualizada com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao atualizar categoria");
            Console.WriteLine(ex.Message);
        }
    }
}