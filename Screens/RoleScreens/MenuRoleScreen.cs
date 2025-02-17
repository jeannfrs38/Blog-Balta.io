using Blog.Screens.RoleScreens;
using Blog.Screens.UserScreens;

namespace Blog.Screens;

public class MenuRoleScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Menu de Perfil");
        Console.WriteLine("--------------");
        Console.WriteLine();
        Console.WriteLine("1 - Cadastrar Perfil");
        Console.WriteLine("2 - Listar Perfil");
        Console.WriteLine("3 - Atualizar Perfil");
        Console.WriteLine("4 - Excluir Perfil");
        Console.WriteLine("5 - Sair");
        Console.WriteLine();
        Console.Write("Selecione uma Opcao: ");
        var option = int.Parse(Console.ReadLine());

        switch (option)
        {
            case 1:
                CreateRoleScreen.Load();
                break;
            case 2:
                ListRoleScreen.Load();
                break;
            case 3:
                UpdateRoleScreen.Load();
                break;
            case 4:
                DeleteRoleScreen.Load();
                break;
            case 5:
                Program.Load();
                break;
            default:
                break;
        }


    }
}