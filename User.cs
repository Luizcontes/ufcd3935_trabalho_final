namespace ufcd3935_trabalho_final;

public class User
{

    int Numero { get; }
    public string Nome { get; }
    string morada;
    string codigoPostal;
    string localidade;
    int Telefone { get; }
    string email;
    int Contribuinte { get; }
    float SaldoDisponivel { get; }
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

}