namespace ufcd3935_trabalho_final;

public class ListarCliente : Strategy
{

    List<User> users;
    public ListarCliente(List<User> users)
    {
        this.users = users;
    }
    public void execute()
    {

        int userN = Menu.listarCliente();
        try
        {
            Menu.imprimirCliente(users[userN]);
            Console.Write(Menu.fimOpcao(1));
        }
        catch (ArgumentOutOfRangeException) {
            Console.Write(Menu.fimOpcao(0));
        }

        Console.ReadLine();
        Console.Clear();
    }

}