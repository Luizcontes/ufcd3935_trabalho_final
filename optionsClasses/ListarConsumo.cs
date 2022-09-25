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
        int userN = Menu.buscarClienteCarregar();
        try
        {
            if (Validation.isClientValid(users[userN - 1]) == true)
            {
                bal = new Balance(userN);
                while (true)
                {
                    Menu.imprimirCliente(users[userN - 1], "LISTAR CARREGAMENTO");
                    // Console.Write("Valor a carregar: ");
                    // valor = Validation.isFloat(Console.ReadLine());
                    // if (valor > 0) {
                    //     break;
                    // }
                    // else if (valor < 0) {
                    //     Console.Write("So e permitido valores positivos...");
                        bal.listarConsumo();
                        break;
                    // }
                    // Console.Clear();
                }
                // bal.addTransaction(DateTime.Now, valor);
                Menu.fimOpcao(1);

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