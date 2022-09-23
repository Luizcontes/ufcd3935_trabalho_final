namespace ufcd3935_trabalho_final;

public class EliminarCliente : Strategy
{
    List<User> users;
    public EliminarCliente(List<User> users)
    {
        this.users = users;
    }
    public void execute() {
        
        int userN = Menu.eliminarCliente();
        try
        {
            if (Validation.isClientValid(users[userN - 1]))
            {
                Menu.imprimirEliminarCliente(users[userN - 1]);
                users[userN - 1].active = false;
                Console.WriteLine("\nCliente Eliminado com sucesso...\n");
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