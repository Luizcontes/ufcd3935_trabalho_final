namespace ufcd3935_trabalho_final;

public class User
{

    public int Numero { get; }
    public string Nome { get; }
    public string morada;
    public string codigoPostal;
    public string localidade;
    public int Telefone { get; }
    public string email;
    public int Contribuinte { get; }
    public float SaldoDisponivel { get; }
    public DateTime Validade { get; set; }

    public User(int numero, string nome, string morada, string codigoPostal, string localidade, int telefone, string email, int contribuinte, float saldoDisponivel, DateTime validade)
    {
        this.Numero = numero;
        this.Nome = nome;
        this.morada = morada;
        this.codigoPostal = codigoPostal;
        this.localidade = localidade;
        this.Telefone = telefone;
        this.email = email;
        this.Contribuinte = contribuinte;
        this.SaldoDisponivel = saldoDisponivel;
        this.Validade = validade;
    }

    public static User objectfy(string line, int numero)
    {

        string[] tokens = line.Split(';');

        string nome = tokens[0];
        string morada = tokens[1];
        string codigoPostal = tokens[2];
        string localidade = tokens[3];
        int telefone = Convert.ToInt32(tokens[4]);
        string email = tokens[5];
        int contribuinte = Convert.ToInt32(tokens[6]);
        float saldoDisponivel = Convert.ToSingle(tokens[7]);
        DateTime validade = DateTime.Parse(tokens[8]);


        User user = new User(numero, nome, morada, codigoPostal, localidade, telefone, email, contribuinte, saldoDisponivel, validade);

        return user;
    }

    public static string stringfy(User u)
    {

        string data =
            u.Nome + ";" +
            u.morada + ";" +
            u.codigoPostal + ";" +
            u.localidade + ";" +
            u.Telefone + ";" +
            u.email + ";" +
            u.Contribuinte + ";" + 
            u.SaldoDisponivel + ";" +
            u.Validade;

        return data;
    }

}