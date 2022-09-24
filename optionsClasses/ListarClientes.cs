namespace ufcd3935_trabalho_final;

public class ListarClientes : Strategy
{
    List<User> users;
    string valid = "all";
    string msg = "LISTAR CLIENTES";
    public ListarClientes(List<User> users)
    {
        this.users = users;
    }
    public ListarClientes(List<User> users, string valid, string msg)
    {
        this.users = users;
        this.valid = valid;
        this.msg = msg;
    }
    public void execute()
    {
        int counter = 0;

        Console.Write($"{this.msg}\n\n");
        for (int i = 0; i < users.Count; i++)
        {
            if (users[i].active == true)
            {
                if ((users[i].Validade.AddDays(30) > DateTime.Now) && (valid == "valid"))
                {
                    Menu.listarClientes(users[i], valid);
                    counter++;
                }
                else if (users[i].Validade.AddDays(30) < DateTime.Now && valid == "invalid")
                {
                    Menu.listarClientes(users[i], valid);
                    counter++;
                }
                else if (valid == "all")
                {
                    Menu.listarClientes(users[i], valid);
                    counter++;
                }
            }
        }

        Console.Write(Menu.fimOpcao(counter));
        Console.ReadLine();
        Console.Clear();
    }

}