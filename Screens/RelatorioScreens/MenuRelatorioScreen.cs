
using System.Threading.Channels;

namespace Blog.Screens.RelatorioScreens;

public class MenuRelatorioScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Bem Vindo ao Menu de Relatorios");
        Console.WriteLine("-------------------------------");
        Console.WriteLine();
        Console.WriteLine("1 - Listar os Usuarios com Seus Perfis ");
        Console.WriteLine("2 - Listar as Categorias com quantidade de Posts vinculados");
        Console.WriteLine("3 - Listar Tags com quantidade de posts vinculados");
        Console.WriteLine("4 - Listar posts de uma categoria vinculadas");
        Console.WriteLine("5 - Listar todos os Post com sua categoria");
        Console.WriteLine("6 - Listar os posts com suas tags");
        Console.WriteLine("7 - Sair");
        Console.WriteLine();
        Console.Write("Escolha uma opcao: ");
        var option = short.Parse(Console.ReadLine());

        switch (option)
        {
            case 1:
                ListarUserRoleScreen.Load();
                break;
            case 2:
                ListarCategoriaPostsQtdScreen.Load();
                break;
            case 3:
                ListarTagsPostsQtdScreen.Load();
                break;
            case 4:
                ListarCategoriaWithPostsScreen.Load();
                break;
            case 5:
                ListarPostsWithCategoriaScreen.Load();
                break;
            case 6:
                ListarPostsWithTagsScreen.Load();
                break;
            case 7:
                Program.Load();
                break;
        }
    }
}