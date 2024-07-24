namespace System;

public class Array
{
    public static int[] ConvertAll(string[] numbers)
    {
        // A method to change a string input of numbers separated with commas into an integer array.
        int index = 0;
        int[] arr = new int[numbers.Length]; // Creates an array of a new length.
        while (index < numbers.Length)
        {
            arr[index] = Convert.ToInt32(numbers[index]);
            index++;
        }

        return arr;
    }

    public static int[] Resize(int[] array, int newSize, params int[]? newNumbers)
    {
        int[] newArray = new int[newSize];
        int leng = 0, additionalLength = 0;
        if (array.Length >= newSize)
        {
            while (leng < newArray.Length)
            {
                newArray[leng] = array[leng];
                leng++;
            }
        }
        else if (array.Length < newSize)
        {
            if (newNumbers.Length > newSize - array.Length)
            {
                Exception e =
                    new Exception(
                        "The length of the new size is not compatible with the old array and the new numbers you added.");
                throw (e);
            }

            for (int i = 0; i < newSize; i++)
            {
                if (i < array.Length)
                {
                    newArray[i] = array[i];
                }
                else
                {
                    newArray[i] = newNumbers[additionalLength++];
                }
            }
        }

        return newArray;
    }

    public static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}