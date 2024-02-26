using System;

public class MainClass
{
    public static void Main()
    {
        string num1 = Console.ReadLine();
        string num2 = Console.ReadLine();
        string num3 = num1 + num2;
        for (int i = 0; i < num1.Length; i++)
        {
            int Count = 0;
            for (int j = 0; j < num3.Length; j++)
            {
                if (num1[i] == num3[j])
                {
                    Count++;
                }
            }
            if (Count == 1)
            {
                Console.WriteLine($"Уникально число {num1[i]}");
            }
        }
    }
}