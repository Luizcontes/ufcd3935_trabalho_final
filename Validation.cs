namespace ufcd3935_trabalho_final;


/* 
    Class created to handle every validation needed in the program.
 */
public class Validation
{

    // Checks whether the user`s option inserted is neither 
    //  null, empty string or has one character returning true in the
    //  case all of these conditions are respected.
    public bool isOptionValid(string? option)
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
}