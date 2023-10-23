using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите элементы массива, разделенные запятыми (например, \"Hello,2,world,:-)\"): ");
        string input = Console.ReadLine()!;
        string[] inputArray = input.Split(',');

        string[] resultArray = FilterArray(inputArray);

        Console.WriteLine("Результат:");
        foreach (string item in resultArray)
        {
            Console.WriteLine(item);
        }
    }

    