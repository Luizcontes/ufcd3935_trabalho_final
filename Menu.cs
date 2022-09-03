namespace ufcd3935_trabalho_final;
public class Menu
{

    /*
    This class contains every text menu needed for the program do display
        information to the user 
     */      
    public static string menuOptions()
    {
        return (
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
    }
    
}