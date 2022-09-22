namespace ufcd3935_trabalho_final;

using System;
class FileManager
{

    public static List<User> readCostumer(string file)
    {
        string path = @$"{Environment.CurrentDirectory}/data/{file}.csv";

        try
        {
            List<User> users = new List<User>();
            if (File.Exists(path))
            {
                StreamReader sr = new(path);
                while (sr.Peek() != -1)
                {
                    string? line = sr.ReadLine();
                    if (line != null)
                        users.Add(User.objectfy(line, users.Count));
                }
                sr.Close();

                return users;
            }
            else
            {
                FileStream fs = File.Create(path);
                fs.Close();
                return new List<User>();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message.ToString());
            return new List<User>();
        }
    }

    public static void writeData(string file, List<User> users)
    {
        string path = @$"{Environment.CurrentDirectory}/data/{file}.csv";

        StreamWriter sw = new StreamWriter(path);
        foreach (User item in users)
        {
            sw.WriteLine(User.stringfy(item));
        }

        sw.Close();
    }
}