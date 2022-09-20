namespace ufcd3935_trabalho_final;


/* 
    Class created to handle every validation needed in the program.
 */
public class Validation
{

    // Checks whether the user`s option inserted is neither 
    //  null, empty string or has one character returning true in the
    //  case all of these conditions are respected.
    public static bool isOptionValid(string? option)
    {
        if (option != "" && option != null && option.Length > 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static int isValidInteger(string? msg)
    {
        while (true)
        {
            try
            {
                Console.Write(msg);
                int intInput = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                return intInput;
            }
            catch (FormatException)
            {
                Console.Clear();
                Console.Write("Fomarto invalido, digite novamente...");
                Thread.Sleep(1000);
                Console.Clear();
            }
        }
    }

    public static float isValidFloat(string? msg)
    {
        while (true)
        {
            try
            {
                Console.Write(msg);
                float floatInput = Convert.ToSingle(Console.ReadLine());
                Console.Clear();
                return floatInput;
            }
            catch (FormatException)
            {
                Console.Clear();
                Console.Write("Fomarto invalido, digite novamente...");
                Thread.Sleep(1000);
                Console.Clear();
            }
        }
    }

    public static string getStringInput(string? msg) {

        Console.Write(msg);
        string? str = Console.ReadLine(); 
        str = str == null ? "" : str;
        Console.Clear();
        return str;
    }
}