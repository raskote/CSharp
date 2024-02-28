// https://stepik.org/lesson/701474/step/11?unit=701545

using System;

public class MainClass
{
    public static void Main()
    {
        string line = Console.ReadLine();
        string[] array = line.Split(' ');
        int summ = 0;
        int[] numbers = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            numbers[i] = int.Parse(array[i]);
            if (numbers[i] % 2 == 0)
            {
                summ += numbers[i];
            }
            
        }
        Console.WriteLine(summ);
    }
}