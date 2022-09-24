namespace ufcd3935_trabalho_final;

using System;

class Balance
{
    public List<string> balance;
    public string num = "";

    public Balance(int num) {
        this.num = num.ToString();
        this.balance = FileManager.readBalance(this.num);
    }

    public void addTransaction(DateTime date, float amount)
    {
        this.balance.Add($"{date};{amount}");
        FileManager.writeBalance(this.num, balance);
    }
}