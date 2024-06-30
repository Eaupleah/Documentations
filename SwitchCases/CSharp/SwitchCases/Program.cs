using CSharp.SwitchCases.Models;

namespace CSharp.SwitchCases;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the season");
        string seasonName = Console.ReadLine();
        Console.WriteLine(SwitchStatement.MonthTranslater(seasonName));
        Console.WriteLine(SwitchExpression.MonthTranslater(seasonName));
    }
}