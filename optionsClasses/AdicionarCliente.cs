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
        Console.WriteLine("Adicionar Cliente!!!");
        User user = Menu.adicionarCliente(users.Count);
        users.Add(user);
        Console.Clear();
    }
}