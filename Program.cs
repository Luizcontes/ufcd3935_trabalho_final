namespace ufcd3935_trabalho_final;

using System;
class Program
{
    
    static void Main(string[] args)
    {

        string fileName = "clients";

        // List created to store users data
        List<User> users = FileManager.readCostumer(fileName);

        while (true)
        {
            string? option = Menu.menuOptions();

            Context context = new Context(new Incorrect());

            if (Validation.isOptionValid(option))
            {
                if (option == "00")
                    context = new Context(new Exit());
                if (option == "01")
                    context = new Context(new ListarClientes(users));
                if (option == "02")
                    context = new Context(new ListarClientes(users, "valid", "CLIENTES COM SALDO DISPONIVEL"));
                if (option == "03")
                    context = new Context(new ListarClientes(users, "invalid", "CLIENTES COM SALDO EXPIRADO"));
                if (option == "04")
                    context = new Context(new ListarCliente(users));
                if (option == "05")
                    context = new Context(new AdicionarCliente(users));
                if (option == "06")
                    context = new Context(new EliminarCliente(users));
                if (option == "07")
                    context = new Context(new ModificarCliente(users));
                if (option == "08")
                    context = new Context(new ListarCarregamento(users));
                if (option == "09")
                    context = new Context(new ListarConsumo(users));
                if (option == "10")
                    context = new Context(new AdicionarCarregamento(users));
                if (option == "11")
                    context = new Context(new AdicionarConsumo(users));
            }

            Console.Clear();
            context.executeStrategy();
            FileManager.writeData(fileName, users);
        }
    }
}
