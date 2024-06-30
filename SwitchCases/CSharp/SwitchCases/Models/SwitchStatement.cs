namespace CSharp.SwitchCases.Models;

public class SwitchStatement
{
    #region MonthTranslater

    public static string MonthTranslater(string season)
    {
        string translation;
        switch (season)
        {
            case "spring":
                translation = "The translation of the season you have entered is: yaz";
                break;
            case "summer":
                translation = "The translation of the season you have entered is: yay";
                break;
            case "autumn":
                translation = "The translation of the season you have entered is: payiz";
                break;
            case "winter":
                translation = "The translation of the season you have entered is: qis";
                break;
            default:
                translation = "Invalid input. Please enter a valid season.";
                break;
        }

        return translation;
    }

    #endregion
}