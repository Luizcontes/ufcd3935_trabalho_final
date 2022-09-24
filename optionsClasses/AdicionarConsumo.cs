namespace ufcd3935_trabalho_final;

public class AdicionarConsumo : Strategy
{
    List<User> users;
    Balance? bal;
    public AdicionarConsumo(List<User> users)
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
                float valor = 0;
                while (true)
                {
                    Menu.imprimirCliente(users[userN - 1], "ADICIONAR CONSUMO");
                    Console.Write("Valor consumido: ");
                    valor = Validation.isFloat(Console.ReadLine());
                    if (valor > 0)
                    {
                        break;
                    }
                    else if (valor < 0)
                    {
                        Console.Write("So e permitido valores positivos...");
                        Console.Read();
                    }
                    Console.Clear();
                }
                bal.addTransaction(DateTime.Now, valor * -1);
                Console.Write("Consumo adicionado com sucesso...");

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