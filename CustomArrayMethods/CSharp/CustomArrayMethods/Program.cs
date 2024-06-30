using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;

namespace CSharp.CustomArrayMethods;

using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the array: ");
        string numbers = Console.ReadLine();
        string[] arrNumbers = numbers.Split(',');
        int[] array = Array.ConvertAll(arrNumbers);

        Console.WriteLine("Enter the new length of the array: ");

        int newLeng = Convert.ToInt32(Console.ReadLine());


        int[] newArr2;

        if (array.Length >= newLeng)
        {
            newArr2 = Array.Resize(array, newLeng);
            Array.PrintArray(newArr2);
        }
        else if (array.Length < newLeng)
        {
            Console.WriteLine("Enter the new numbers: ");
            string newNumbers = Console.ReadLine();
            string[] newArrNumbers = newNumbers.Split(",");
            int[] newArray = Array.ConvertAll(newArrNumbers);

            newArr2 = Array.Resize(array, newLeng, newArray);
            Array.PrintArray(newArr2);
        }
    }
}