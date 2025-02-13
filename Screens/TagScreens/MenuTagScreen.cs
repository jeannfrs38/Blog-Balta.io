namespace Blog.Screens.TagScreens;

public class MenuTagScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Gestao de Tags");
        Console.WriteLine("---------------");
        Console.WriteLine("O que deseja fazer?");
        Console.WriteLine();
        Console.WriteLine("1 - Adicionar Tag");
        Console.WriteLine("2 - Listar Tag");
        
        Console.WriteLine();
        var option = short.Parse(Console.ReadLine()!);

        switch (option)
        {
            case 1:
                CreateTagScreen.Load();
                break;
            case 2:
                ListTagScreen.Load();
                break;
            case 3:
                UpdateTagScreen.Load();
                break;
            case 4:
                DeleteTagScreen.Load();
                break;
            default:
                Load();
                break;
        }
    }
}