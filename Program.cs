namespace ufcd3935_trabalho_final;

using System;
class Program
{
    static void Main(string[] args)
    {
        
        // List created to store users data
        List<User> users = new List<User>();
        
        string? option;
        Validation validation = new Validation();
        Context context;

        while (true)
        {
            option = Menu.menuOptions();

            context = new Context(new Incorrect());

            if (validation.isOptionValid(option))
            {
                if (option == "00")
                    context = new Context(new Exit());
                if (option == "01")
                    context = new Context(new ListarClientes());
                if (option == "02")
                    context = new Context(new SaldoAtivo());
                if (option == "03")
                    context = new Context(new ValidadeExpirada());
                if (option == "04")
                    context = new Context(new ListarCliente());
                if (option == "05")
                    context = new Context(new AdicionarCliente(users));
                if (option == "06")
                    context = new Context(new EliminarCliente());
                if (option == "07")
                    context = new Context(new ModificarCliente());
                if (option == "08")
                    context = new Context(new ListarCarregamento());
                if (option == "09")
                    context = new Context(new ListarConsumo());
                if (option == "10")
                    context = new Context(new AdicionarCarregamento());
                if (option == "11")
                    context = new Context(new AdicionarConsumo());
            }

            Console.Clear();
            context.executeStrategy();
            Console.ReadLine();
        }
    }
}
