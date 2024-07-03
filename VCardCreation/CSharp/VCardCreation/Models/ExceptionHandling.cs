namespace CSharp.VCardCreation.Models;

public class ExceptionHandling
{
    public class UserLimitException : Exception
    {
        // Exception sinifini miras alarak kendi Custom Exceptionumuzu olusturuyoruz, parametre olarak istedigimiz error mesajini belirtiyoruz.

        public UserLimitException(string message) : base(message)

        {
        }
    }
}