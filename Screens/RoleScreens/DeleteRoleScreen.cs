using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.RoleScreens;

public class DeleteRoleScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Excluir Perfil Cadastrado");
        Console.WriteLine("-------------------------");
        Console.WriteLine();
        Console.Write("Qual o Id do perfil que deseja excluir: ");
        var id = int.Parse(Console.ReadLine());
        
        Delete(id);
        Console.ReadKey();
        MenuRoleScreen.Load();
    }

    public static void Delete(int id)
    {
        try
        {
            var repository = new Repository<Role>(Database.Connection);
            repository.Delete(id);
            Console.WriteLine(" O perfil foi excluido com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao tentar excluir o perfil");
            Console.WriteLine(ex.Message);
        }
    }
}