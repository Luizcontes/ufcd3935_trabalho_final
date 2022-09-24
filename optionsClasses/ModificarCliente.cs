namespace ufcd3935_trabalho_final;

public class ModificarCliente : Strategy
{
    List<User> users;
    public ModificarCliente(List<User> users)
    {
        this.users = users;
    }
    public void execute()
    {

        int userN = Menu.modificarCliente();
        string field = "";
        try
        {
            if (Validation.isClientValid(users[userN - 1]) == true)
            {
                Menu.imprimirAtualizarCliente(users[userN - 1], "ATUALIZAR CLIENTE");
                field = Menu.modificarCampo();

                while (true)
                {
                    Menu.imprimirAtualizarCliente(users[userN - 1], "ATUALIZAR CLIENTE");
                    Console.Write(field + ": ");
                    string? data = Console.ReadLine();
                    data = data == null ? "" : data;
                    if (users[userN - 1].atualizaDado(field, data))
                    {
                        break;
                    }
                    Console.Clear();
                }
                Console.Clear();
                Menu.imprimirAtualizarCliente(users[userN - 1], "ATUALIZAR CLIENTE");
                Console.Write($"{field} atualizado com sucesso...");
                Console.Read();
            }
            else
            {
                Console.Write(Menu.fimOpcao(0));
                Console.ReadLine();
            }
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.Write(Menu.fimOpcao(0));
        }

        Console.Clear();
    }

}