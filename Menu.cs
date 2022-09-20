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
        string? titulo = "ADICIONAR NOVO CLIENTE\n\n";

        string? nome = Validation.getStringInput(titulo + "Nome: ");
        string? morada = Validation.getStringInput(titulo + "Morada: ");
        string? codigoPostal = Validation.getStringInput(titulo + "Codigo Postal: ");
        string? localidade = Validation.getStringInput(titulo + "Localidade: ");
        int telefone = Validation.isValidInteger(titulo + "Telefone: ");
        string? email = Validation.getStringInput(titulo + "E-mail: ");
        int contribuinte = Validation.isValidInteger(titulo + "NIF: ");
        float saldoDisponivel = Validation.isValidFloat(titulo + "Saldo Disponivel: ");
        
        return new User(numero, nome, morada, codigoPostal, localidade, telefone, email, contribuinte, 10, DateTime.Now);
    }

}