// https://stepik.org/lesson/701474/step/12?unit=701545

using System;

public class MainClass
{
    public static void Main()
    {
        string line = Console.ReadLine();
        string[] array = line.Split(' ');
        int[] numbers = new int[array.Length];
        int max = int.MinValue;
        int min = int.MaxValue;
        for (int i = 0; i < array.Length; i++)
        {
            numbers[i] = int.Parse(array[i]);
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
            else if (numbers[i] > max)
            { 
                max = numbers[i];
            }
        }
        Console.WriteLine($"Наименьшее значение = {min}");
        Console.WriteLine($"Наибольшее значение = {max}");

    }
}