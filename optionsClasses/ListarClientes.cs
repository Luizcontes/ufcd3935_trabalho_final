namespace ufcd3935_trabalho_final;

public class ListarClientes : Strategy
{
    List<User> users;
    string valid = "all";
    public ListarClientes(List<User> users)
    {
        this.users = users;
    }
    public ListarClientes(List<User> users, string valid)
    {
        this.users = users;
        this.valid = valid;
    }
    public void execute()
    {
        for (int i = 0; i < users.Count; i++)
        {
            if ((users[i].Validade.AddDays(30) > DateTime.Now) && (valid == "valid"))
            {
                Menu.listarClientes(users[i], valid);
            }
            else if (users[i].Validade.AddDays(30) < DateTime.Now && valid == "invalid")
            {
                Menu.listarClientes(users[i], valid);
            }
            else if (valid == "all")
            {
                Menu.listarClientes(users[i], valid);
            }
        }

        Console.Write(Menu.fimOpcao(users.Count));
        Console.ReadLine();
        Console.Clear();
    }

}