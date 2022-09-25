namespace ufcd3935_trabalho_final;

using System;

class Balance
{
    public List<string> balance;
    public string num = "";

    public Balance(int num)
    {
        this.num = num.ToString();
        this.balance = FileManager.readBalance(this.num);
    }

    public float addTransaction(DateTime date, float amount)
    {
        string amountString = String.Format("{0:0.00}", amount);
        this.balance.Add($"{date};{amountString}");
        FileManager.writeBalance(this.num, balance);

        return this.updateBalance(); ;
    }

    public void listarCarregamento()
    {

        Console.WriteLine("Consumos:");
        foreach (string item in balance)
        {
            string[] tokens = item.Split(';');
            if (Convert.ToSingle(tokens[1]) > 0)
            {
                Console.Write($"\t> {tokens[0]}");
                Console.WriteLine($" ... {tokens[1]}");
            }
        }
    }

    public void listarConsumo()
    {

        Console.WriteLine("Consumos:");
        foreach (string item in balance)
        {
            string[] tokens = item.Split(';');
            if (Convert.ToSingle(tokens[1]) < 0)
            {
                Console.Write($"\t> {tokens[0]}");
                Console.WriteLine($" ... {tokens[1]}");
            }
        }
    }

    public float updateBalance()
    {

        float newBalance = 0;
        foreach (string item in balance)
        {
            string[] tokens = item.Split(';');
            newBalance += Convert.ToSingle(tokens[1]);
        }   

        return newBalance;
    }
}