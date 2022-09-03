namespace ufcd3935_trabalho_final;

public class Exit : Strategy {

    public void execute() {
        System.Environment.Exit(1);
    }
}