namespace ufcd3935_trabalho_final;

public class ListarConsumo : Strategy
{
    List<User> users;
    Balance? bal;
    public ListarConsumo(List<User> users)
    {
        this.users = users;
    }
    public void execute()
    {
        int userN = Menu.listarClienteConsumo();
        try
        {
            if (Validation.isClientValid(users[userN - 1]) == true)
            {
                bal = new Balance(userN);
                while (true)
                {
                    Menu.imprimirCliente(users[userN - 1], "LISTAR CONSUMO");

                    bal.listarConsumo();
                    Console.Write(Menu.fimOpcao(1));
                    break;

                }

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

        // Console.Write("Pressione qualquer tecla para continuar...");
        Console.ReadLine();
        Console.Clear();
    }
}