//https://stepik.org/lesson/701474/step/14?unit=701545

using System;
public class MainClass
{
    public static void Main()
    {
        string cardNumber = Console.ReadLine();
        int[] numbers = new int[cardNumber.Length];
        int min = int.MaxValue;
        int max = int.MinValue;
        int count = cardNumber.Length;

        for (int i = 0; i < cardNumber.Length; i++)
        {
            numbers[i] = cardNumber[count - i - 1] - '0';
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
            else if (numbers[i] > max)
            {
                max = numbers[i];
            }

        }
        Console.WriteLine($"{String.Join("", numbers)}{max}{min}");
    }
}