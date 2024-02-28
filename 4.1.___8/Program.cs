//https://stepik.org/lesson/701474/step/16?unit=701545
using System;

public class MainClass
{
    public static void Main()
    {
        string line = Console.ReadLine();
        string[] array = line.Split(' ');
        int[] numbers = new int[array.Length];
        int t;
        for (int i = 0; i < array.Length; i++)
        {
            numbers[i] = int.Parse(array[i]);
        }
        
        
        
        for (int j = 0; j < array.Length-1; j++)
            for (int k = 0; k < array.Length-1; k++)
            {
                if (numbers[k] > numbers[k + 1])
                {
                    t = numbers[k];
                    numbers[k] = numbers[k + 1];
                    numbers[k + 1] = t;
                }
        }
    Console.WriteLine($"{String.Join(" ", numbers)}");
    Console.ReadLine();
    }
}