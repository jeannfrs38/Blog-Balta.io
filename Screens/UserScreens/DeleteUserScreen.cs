using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserScreens;

public class DeleteUserScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Excluir um Usuario do Cadastro");
        Console.WriteLine("------------------------------");
        Console.Write("Qual o Id do usuario: ");
        var id = int.Parse(Console.ReadLine());

        Delete(id);
        Console.ReadKey();
        MenuUserScreen.Load();
    }

    public static void Delete(int id)
    {
        try
        {
            var repository = new Repository<User>(Database.Connection);
            repository.Delete(id);
            Console.WriteLine("Usuario Excluido com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Nao foi possivel excluir o Usuario");
            Console.WriteLine(ex.Message);
        }
    }
}