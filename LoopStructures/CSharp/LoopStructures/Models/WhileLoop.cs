namespace CSharp.LoopStructures.Models;

public class WhileLoop
{
    #region CreateLottery

    public static void CreateLottery(int leng)
    {
        while (leng > 6 || leng < 1)
        {
            Console.WriteLine("The number should be between 1 and 6, try again.");
            leng = Convert.ToInt32(Console.ReadLine());
        }

        Random random = new Random();
        List<int[]> lotteryNumbers = new List<int[]>();
        int i = 0, j = 0;
        int newNumber = 0;
        int size = 1;
        int[] numbers = new int[size];
        while (i != leng)
        {
            j = 0;
            size = 1;
            while (j != leng)
            {
                newNumber = random.Next(1, 50);
                numbers[j] = newNumber;
                size++;
                j++;
                Array.Resize(ref numbers, size);
            }


            lotteryNumbers.Add(numbers);
            Array.Resize(ref numbers, 1);
            i++;
        }

        CheckNumbers(lotteryNumbers, leng);
    }

    #endregion

    #region CheckNumbers

    public static void CheckNumbers(List<int[]> list, int leng)
    {
        {
            Random random = new Random();
            int i = 0, j = 0;
            int checkNumber;
            while (i != leng)
            {
                j = 0;
                while (j != leng)
                {
                    checkNumber = list[i][j];
                    if (Array.IndexOf(list[i], checkNumber) == Array.LastIndexOf(list[i], checkNumber))
                    {
                        j++;
                    }
                    else
                    {
                        list[i][j] = random.Next(1, 50);
                        j++;
                    }
                }

                i++;
            }

            Manager.PrintList(list, leng);
        }
    }

    #endregion
}