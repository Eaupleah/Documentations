namespace CSharp.LoopStructures.Models;

public class ForLoop
{
    #region FindMinNumber

    public static void FindMinNumber(int[] array)
    {
        int min = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (min > array[i])
            {
                min = array[i];
            }
        }

        Console.WriteLine($"Minimum number in the array is: {min}");
    }

    #endregion

    #region FindMaxNumber

    public static void FindMaxNumber(int[] array)
    {
        int max = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (max < array[i])
            {
                max = array[i];
            }
        }

        Console.WriteLine($"Maximum number in the array is: {max}");
    }

    #endregion

    #region CountOddNumbers

    public static void CountOddNumbers(int[] array)
    {
        int countOfOddNumbers = 0;
        foreach (int number in array)
        {
            int number2 = Math.Abs(number);
            if (number2 % 2 == 1)
            {
                countOfOddNumbers++;
            }
        }

        Console.WriteLine($"The count of the odd numbers is: {countOfOddNumbers}");
    }

    #endregion

    #region CountEvenNumbers

    public static void CountEvenNumbers(int[] array)
    {
        int countOfEvenNumbers = 0;
        foreach (int number in array)
        {
            int number2 = Math.Abs(number);
            if (number2 % 2 == 0)
            {
                countOfEvenNumbers++;
            }
        }

        Console.WriteLine($"The count of the even numbers is: {countOfEvenNumbers}");
    }

    #endregion

    #region SumOfDigits

    public static void SumOfDigits(int number)
    {
        int sumOfDigits = 0;
        int num2 = number;
        while (number != 0)
        {
            sumOfDigits = sumOfDigits + number % 10;
            number = number - number % 10;
            number = number / 10;
        }

        Console.WriteLine($"The number you entered is {num2}. The sum of its digits is {sumOfDigits}.");
    }

    #endregion

    #region PrintSquare

    public static void PrintSquare(int leng)
    {
        for (int i = 0; i < leng; i++)
        {
            for (int j = 0; j < leng; j++)
            {
                Console.Write("* ");
            }

            Console.WriteLine();
        }
    }

    #endregion

    #region PrintHollowSquare

    public static void PrintHollowSquare(int leng)
    {
        for (int i = 0; i < leng; i++)
        {
            Console.WriteLine();
            for (int j = 0; j < leng; j++)
            {
                if (i == 0 || i == leng - 1 || j == 0 || j == leng - 1)
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write("  ");
                }
            }
        }

        Console.WriteLine();
    }

    #endregion

    #region PrintRightTriangle

    public static void PrintRightTriangle(int leng)
    {
        int leng2 = 0;
        for (int i = 0; i < leng; i++)
        {
            for (int j = 0; j <= leng2; j++)
            {
                Console.Write("* ");
            }

            Console.WriteLine();
            leng2++;
        }
    }

    #endregion

    #region PrintMultiplicationTable

    public static void PrintMultiplicationTable()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine();
            for (int j = 1; j <= 10; j++)
            {
                Console.Write($"{i} * {j} = {i * j} ");
                Console.WriteLine();
            }
        }
    }

    #endregion

    #region VerifyOTP

    public static void VerifyOTP()
    {
        Random random = new Random();
        long otp = random.Next(10000000, 99999999);
        Console.WriteLine($"Your verification code is: {otp}. Please enter the code.");
        int enteredNumber;
        int attempts = 3;
        for (int i = 0; i < 3; i++)
        {
            enteredNumber = Convert.ToInt32(Console.ReadLine());
            if (enteredNumber == otp)
            {
                Console.WriteLine("Verification process successful!");
                break;
            }
            else
            {
                attempts--;
                if (attempts == 0)
                {
                    Console.WriteLine("Please try again, you have used all of your attempts.");
                }
                else
                {
                    Console.WriteLine(
                        $"Verification code is not correct! New verification code: {otp = random.Next(10000000, 99999999)}");
                    Console.WriteLine($"You left {attempts} chance(s)");
                }
            }
        }
    }

    #endregion
    
}