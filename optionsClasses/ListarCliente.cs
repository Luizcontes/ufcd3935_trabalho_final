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
            if (Validation.isClientValid(users[userN - 1]) == true)
            {
                Menu.imprimirCliente(users[userN - 1]);
                Console.Write(Menu.fimOpcao(1));
            }
            else
            {
                Console.Write(Menu.fimOpcao(0));
            }
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.Write(Menu.fimOpcao(0));
        }

        Console.ReadLine();
        Console.Clear();
    }

}