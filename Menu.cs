namespace ufcd3935_trabalho_final;
public class Menu
{

    /*
    This class contains every text menu needed for the program do display
        information to the user 
     */
    public static string menuOptions()
    {
        Console.Write(
            "00. Sair do Programa\n" +
            "01. Listar Todos o Cliente Ativos\n" +
            "02. Listar os Clientes Ativos com Saldo Disponivel\n" +
            "03. Listar os Clientes Ativos com Validade expirada\n" +
            "04. Listar Dados Completos de um Cliente\n" +
            "05. Adicionar um Cliente\n" +
            "06. Eliminar um Cliente\n" +
            "07. Atualizar um Cliente\n" +
            "08. Listar Carregamentos de um Cliente\n" +
            "09. Listar Consumos de um Cliente\n" +
            "10. Adicionar Carregamento\n" +
            "11. Adicionar Consumo\n\n" +
            "Choose an option: "
        );

        string? option = Console.ReadLine();
        return option == null ? "" : option;
    }

    public static void listarClientes(User user, string valid)
    {
        Console.WriteLine("Numero..............: \t" + (user.Numero + 1));
        Console.WriteLine("Nome................: \t" + user.Nome);
        if (valid == "all")
            Console.WriteLine("NIF.................: \t" + user.Contribuinte);
        Console.WriteLine("Saldo Disponivel....: \t" + String.Format("{0:0.00}", user.SaldoDisponivel) + " EUR");
        if (valid == "valid")
            Console.WriteLine("Validade............: \t" + user.Validade.AddDays(30));
        if (valid == "invalid") {
            Console.WriteLine("Vencido.............: \t" + 
            String.Format("{0:0}", 
            (DateTime.Now - user.Validade.AddDays(30)).TotalDays) + " dias");
        }
        Console.WriteLine();
    }

    public static int listarCliente()
    {

        string? msg = "LISTAR CLIENTE\n\n" +
            "Digite o numero do cliente para listar\n" +
            "Numero : ";
        return Validation.isValidInteger(msg);
    }

    public static User adicionarCliente(int numero)
    {
        string? titulo = "ADICIONAR NOVO CLIENTE\n\n";

        string? nome = Validation.getStringInput(titulo + "Nome: ");
        string? morada = Validation.getStringInput(titulo + "Morada: ");
        string? codigoPostal = Validation.getStringInput(titulo + "Codigo Postal: ");
        string? localidade = Validation.getStringInput(titulo + "Localidade: ");
        int telefone = Validation.isValidInteger(titulo + "Telefone: ");
        string? email = Validation.getStringInput(titulo + "E-mail: ");
        int contribuinte = Validation.isValidInteger(titulo + "NIF: ");
        float saldoDisponivel = Validation.isValidFloat(titulo + "Saldo Disponivel: ");

        return new User(numero, nome, morada, codigoPostal, localidade, telefone, email, contribuinte, saldoDisponivel, DateTime.Now);
    }

    public static string fimOpcao(int opt)
    {
        if (opt != 0)
        {
            return "Pressione qualquer tecla para continuar...";
        }
        return "Nao ha cliente cadastrado com este numero...";
    }

    public static void imprimirCliente(User user)
    {

        Console.Write("LISTAR CLIENTE\n\n");
        Console.WriteLine("Numero..............: \t" + (user.Numero + 1));
        Console.WriteLine("Nome................: \t" + user.Nome);
        Console.WriteLine("Morada..............: \t" + user.morada);
        Console.WriteLine("Codigo Postal.......: \t" + user.codigoPostal);
        Console.WriteLine("Localidade..........: \t" + user.localidade);
        Console.WriteLine("Telefone............: \t" + user.Telefone);
        Console.WriteLine("E-mail..............: \t" + user.email);
        Console.WriteLine("NIF.................: \t" + user.Contribuinte);
        Console.WriteLine("Saldo Disponivel....: \t" + String.Format("{0:0.00}", user.SaldoDisponivel) + " EUR");
        Console.WriteLine("Validade............: \t" + user.Validade.AddDays(30));
        Console.WriteLine();
    }
}