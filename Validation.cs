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
            catch (OverflowException)
            {
                Console.Clear();
                Console.Write("Numero invalido, digite novamente...");
                Thread.Sleep(1000);
                Console.Clear();
            }
        }
    }

    public static int isInteger(string? data)
    {

        try
        {
            return Convert.ToInt32(data);
        }
        catch (Exception)
        {
            Console.Write("Campo em formato incorreto...");
            Console.Read();
            return 0;
        }
    }

    public static string isValidField(string? msg)
    {
        while (true)
        {
            Console.Write(msg);
            string? field = Console.ReadLine();
            field = field == null ? "" : field.ToLower();
            Console.Clear();
            switch (field)
            {
                case "nome":
                    return "Nome";
                case "morada":
                    return "Morada";
                case "codigo postal":
                    return "Codigo Postal";
                case "localidade":
                    return "Localidade";
                case "telefone":
                    return "Telefone";
                case "e-mail":
                    return "E-mail";
                case "nif":
                    return "NIF";
                default:
                    Console.Write("Escolha a opcao correta...");
                    Console.Read();
                    break;
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

    public static bool isClientValid(User user)
    {

        if (user.active)
        {
            return true;
        }
        return false;
    }

    public static string getStringInput(string? msg)
    {

        Console.Write(msg);
        string? str = Console.ReadLine();
        str = str == null ? "" : str;
        Console.Clear();
        return str;
    }
}