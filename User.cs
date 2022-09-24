namespace ufcd3935_trabalho_final;

public class User
{

    public int Numero { get; }
    public bool active;
    public string Nome { get; set; }
    public string morada;
    public string codigoPostal;
    public string localidade;
    public int Telefone { get; set; }
    public string email;
    public int Contribuinte { get; set; }
    public float SaldoDisponivel { get; }
    public DateTime Validade { get; set; }

    public User(int numero, bool active, string nome, string morada, string codigoPostal, string localidade, int telefone, string email, int contribuinte, float saldoDisponivel, DateTime validade)
    {
        this.Numero = numero;
        this.active = active;
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

        bool active = Convert.ToBoolean(tokens[0]);
        string nome = tokens[1];
        string morada = tokens[2];
        string codigoPostal = tokens[3];
        string localidade = tokens[4];
        int telefone = Convert.ToInt32(tokens[5]);
        string email = tokens[6];
        int contribuinte = Convert.ToInt32(tokens[7]);
        float saldoDisponivel = Convert.ToSingle(tokens[8]);
        DateTime validade = DateTime.Parse(tokens[9]);


        User user = new User(numero, active, nome, morada, codigoPostal, localidade, telefone, email, contribuinte, saldoDisponivel, validade);

        return user;
    }

    public static string stringfy(User u)
    {

        string data =
            u.active + ";" +
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

    public bool atualizaDado(string field, string data) {

            switch(field.ToLower()) {
                case "nome":
                    this.Nome = data;
                    return true;
                case "morada":
                    this.morada = data;
                    return true;
                case "codigo postal":
                    this.codigoPostal = data;
                    return true;
                case "localidade":
                    this.localidade = data;
                    return true;
                case "telefone":
                    this.Telefone = Validation.isInteger(data);
                    if (this.Telefone == 0) {
                        return false;
                    }
                    return true;
                case "e-mail":
                    this.email = data;
                    return true;
                case "nif":
                    this.Contribuinte = Validation.isInteger(data);
                    if (this.Contribuinte == 0) {
                        return false;
                    }
                    return true;
                default:
                    Console.Write("Escolha a opcao correta...");
                    Console.Read();
                    return false;
            }
    }

}