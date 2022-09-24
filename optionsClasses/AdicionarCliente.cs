namespace ufcd3935_trabalho_final;

public class AdicionarCliente : Strategy
{
    List<User> users;
    Balance? bal;
    public AdicionarCliente(List<User> users)
    {
        this.users = users;
    }

    public void execute()
    {
        User user = Menu.adicionarCliente(users.Count);
        users.Add(user);
        this.bal = new Balance(users.Count);
        bal.addTransaction(user.Validade, user.SaldoDisponivel);
        Console.Clear();
        Menu.imprimirCliente(user, "ADICIONAR CLIENTE");
        Console.Write("Cliente adicionado com sucesso...");
        Console.Read();
        Console.Clear();
    }
}