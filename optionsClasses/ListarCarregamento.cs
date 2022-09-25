namespace ufcd3935_trabalho_final;

public class ListarCarregamento : Strategy
{
    List<User> users;
    Balance? bal;
    public ListarCarregamento(List<User> users)
    {
        this.users = users;
    }
    public void execute()
    {
        int userN = Menu.listarClienteCarregamento();
        try
        {
            if (Validation.isClientValid(users[userN - 1]) == true)
            {
                bal = new Balance(userN);
                while (true)
                {
                    Menu.imprimirCliente(users[userN - 1], "LISTAR CARREGAMENTO");

                    bal.listarCarregamento();
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

        Console.ReadLine();
        Console.Clear();
    }

}