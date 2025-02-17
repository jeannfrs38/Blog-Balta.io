namespace Blog.Screens.CatagoryScreens;

public class MenuCategoryScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Gestao de Categoria");
        Console.WriteLine("--------------------");
        Console.WriteLine();
        Console.WriteLine("1 - Criar Categoria");
        Console.WriteLine("2 - Listar Categorias");
        Console.WriteLine("3 - Atualizar Categorias");
        Console.WriteLine("4 - Excluir Categoria");
        Console.WriteLine("5 -  Sair");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Selecione uma opcao: ");
        var option = int.Parse(Console.ReadLine());

        switch (option)
        {
            case 1:
                CreateCategoryScreen.Load();
                break;
            case 2:
                ListCategoryScreen.Load();
                break;
            case 3:
                UpdateCategoryScreen.Load();
                break;
            case 4:
                DeleteCategoryScreen.Load();
                break;
            case 5:
                Program.Load();
                break;
            default:
                break;
        }
    }
    
}