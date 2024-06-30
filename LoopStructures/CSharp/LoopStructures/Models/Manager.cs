namespace CSharp.LoopStructures.Models;

public class Manager
{
    #region PrintList

    public static void PrintList(List<int[]> list, int leng)
    {
        int i = 0, j = 0;
        while (i != leng)
        {
            j = 0;
            while (j != leng)
            {
                Console.Write(list[i][j] + " ");
                j++;
            }

            i++;
            Console.WriteLine();
        }
    }

    #endregion

    #region PrintList

    public static string PrintList(List<int> list)
    {
        string numbers = null;
        for (int i = 0; i < list.Count; i++)
        {
            numbers = numbers + $"{list[i]}, ";
        }

        return numbers;
    }

    #endregion

    #region FillArray

    public static int[] FillArray()
    {
        Console.WriteLine("Enter the numbers:");
        string numbers = Console.ReadLine();
        string[] numbersArray = numbers.Split(",");
        int[] arr = Array.ConvertAll(numbersArray, int.Parse);
        return arr;
    }

    #endregion
}