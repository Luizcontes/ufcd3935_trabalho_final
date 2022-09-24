namespace ufcd3935_trabalho_final;

public class AdicionarCliente : Strategy
{
    List<User> users;
    public AdicionarCliente(List<User> users)
    {
        this.users = users;
    }

    public void execute()
    {
        User user = Menu.adicionarCliente(users.Count);
        users.Add(user);
        Console.Clear();
        Menu.imprimirCliente(user, "ADICIONAR CLIENTE");
        Console.Write("Cliente adicionado com sucesso...");
        Console.Read();
        Console.Clear();
    }
}