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
            "04. Lista Dados Completos de um Cliente\n" +
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

    public static User adicionarCliente(int numero)
    {
        Console.Write("Nome: ");
        string? nome = Console.ReadLine();
        nome = nome == null ? "" : nome;
        Console.Write("Morada: ");
        string? morada = Console.ReadLine();
        morada = morada == null ? "" : morada;
        Console.Write("Codigo Postal: ");
        string? codigoPostal = Console.ReadLine();
        codigoPostal = codigoPostal == null ? "" : codigoPostal;
        Console.Write("Localidade: ");
        string? localidade = Console.ReadLine();
        localidade = localidade == null ? "" : codigoPostal;
        Console.Write("Telefone: ");
        int telefone = Console.ReadLine();
        // telefone = telefone == null ? "" : telefone;
        Console.Write("E-mail: ");
        string? email = Console.ReadLine();
        email = email == null ? "" : email;
        Console.Write("NIF: ");
        int contribuinte = Console.ReadLine();
        // contribuinte = contribuinte == null ? "" : contribuinte;
        Console.Write("Saldo Disponivel: ");
        float saldoDisponivel = Console.ReadLine();
        // saldoDisponivel = saldoDisponivel == null ? "" : saldoDisponivel;
        
        User user = new User(numero, nome, morada, codigoPostal, localidade, telefone, email, contribuinte, saldoDisponivel, DateTime.Now);

        return user;
    }

}