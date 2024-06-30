namespace CSharp.LoopStructures.Models;

public class ForEachLoop
{
    #region CategorizeNumbers

    public static void CategorizeNumbers(int[] array,
        out int countDivisibleThree,
        out int countDivisibleTwo,
        out List<int> divisibleTwo,
        out List<int> notDivisibleTwo,
        out int countOdd,
        out int countEven)
    {
        divisibleTwo = new List<int>();
        notDivisibleTwo = new List<int>();
        countDivisibleThree = 0;
        countDivisibleTwo = 0;
        countOdd = 0;
        countEven = 0;
        foreach (int numbers in array)
        {
            if (numbers % 2 == 0 && numbers % 3 == 0)
            {
                divisibleTwo.Add(numbers);
                countEven++;
                countDivisibleThree++;
                countDivisibleTwo++;
            }
            else if (numbers % 2 == 0)
            {
                divisibleTwo.Add(numbers);
                countEven++;
                countDivisibleTwo++;
            }
            else if (numbers % 2 == 1)
            {
                countOdd++;
                notDivisibleTwo.Add(numbers);
                if (numbers % 3 == 0)
                {
                    countDivisibleThree++;
                }
            }
        }
    }

    #endregion
}