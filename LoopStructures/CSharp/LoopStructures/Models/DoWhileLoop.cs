namespace CSharp.LoopStructures.Models;

public class DoWhileLoop
{
    #region CreateAccount

    public static void CreateAccount()
    {
        Console.WriteLine("Please choose a username for your account");
        string username = Console.ReadLine();
        Console.WriteLine("Create a password for your account");
        string password = Console.ReadLine();

        UserLogin(username, password);
    }

    #endregion

    #region UserLogin

    public static void UserLogin(string username, string password)
    {
        bool a = false;
        Console.WriteLine("Enter the username:");
        string username2 = Console.ReadLine();
        Console.WriteLine("Enter the password:");
        string password2 = Console.ReadLine();
        do
        {
            if (username2 != username)
            {
                Console.WriteLine("Username is not correct, enter again.");
                username2 = Console.ReadLine();
            }
            else if (password2 != password)
            {
                Console.WriteLine("Password is not correct, enter again.");
                password2 = Console.ReadLine();
                continue;
            }
            else
            {
                a = true;
                Console.WriteLine("Login process is successful.");
            }
        } while (a is false);
    }

    #endregion
}