namespace ufcd3935_trabalho_final;

public class ListarClientes : Strategy
{
    List<User> users;
    public ListarClientes(List<User> users)
    {
        this.users = users;
    }
    public void execute()
    {

        for (int i = 0; i < users.Count; i++)
        {
            Menu.listarClientes(users[i]);
        }

        Console.Write("Pressione qualquer tecla para continuar...");
        Console.ReadLine();
        Console.Clear();
    }

}