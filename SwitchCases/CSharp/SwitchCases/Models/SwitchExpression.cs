namespace CSharp.SwitchCases.Models;

public class SwitchExpression
{
    #region MonthTranslater

    public static string MonthTranslater(string season)
    {
        string translation;
        translation = season switch
        {
            "spring" => "The translation of the season you have entered is: yaz",
            "summer" => "The translation of the season you have entered is: yay",
            "autumn" => "The translation of the season you have entered is: payiz",
            "winter" => "The translation of the season you have entered is: qis",
            _ => "Invalid input. Please enter a valid season."
        };
        return translation;
    }

    #endregion
}