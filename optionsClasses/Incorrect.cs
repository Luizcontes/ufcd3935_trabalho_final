namespace ufcd3935_trabalho_final;

public class Incorrect : Strategy {

    public void execute() {
        Console.WriteLine("Please choose a correct option...");
        Thread.Sleep(1000);
        Console.Clear();
    }
}