namespace Blog.Screens.UserScreens;

public class MenuUserScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Menu do Usuario");
        Console.WriteLine("---------------");
        Console.WriteLine();
        Console.WriteLine("1 - Criar novo usuario");
        Console.WriteLine("2 - Atualizar cadastro de usuario");
        Console.WriteLine("3 - Lista usuarios cadastrados");
        Console.WriteLine("4 - Excluir usuario");
        Console.WriteLine("5 - Sair");
        Console.WriteLine("----------------");
        Console.WriteLine();
        Console.Write("Selecione uma opcao: ");
        var option = int.Parse(Console.ReadLine());

        switch (option)
        {
            case 1:
                CreateUserScreen.Load();
                break;
            case 2:
                UpdateUserScreen.Load();
                break;
            case 3:
                ListUserScreen.Load();
                break;
            case 4:
                DeleteUserScreen.Load();
                break;
            case 5:
                Program.Load();
                break;
            default: 
                Load();
                break;
        }

    }
}