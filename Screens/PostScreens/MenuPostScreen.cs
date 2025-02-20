namespace Blog.Screens.PostScreens;

public class MenuPostScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Menu Post");
        Console.WriteLine("----------");
        Console.WriteLine();
        Console.WriteLine("1 - Criar Post");
        Console.WriteLine("2 - Listar Posts");
        Console.WriteLine("3 - Atualizar Post");
        Console.WriteLine("4 - Excluir Post");
        Console.WriteLine("5 - Sair");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Selecione uma opcao:");
        var option = int.Parse(Console.ReadLine());

        switch (option)
        {
            case 1:
                CreatePostScreen.Load();
                break;
            case 2:
                ListPostScreen.Load();
                break;
            case 3:
                UpdatePostScreen.Load();
                break;
            case 4:
                DeletePostScreen.Load();
                break;
            case 5:
                Program.Load();
                break;
        }
    }
}