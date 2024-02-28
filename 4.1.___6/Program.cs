//https://stepik.org/lesson/701474/step/13?unit=701545

using System;

public class MainClass
{
    public static void Main()
    {
        string grades = Console.ReadLine();
        string[] array = grades.Split(',');
        int[] numbers = new int[array.Length];
        int count2 = 0;
        int count3 = 0;
        int count5 = 0;
        for (int i = 0; i < array.Length; i++)
        {
            numbers[i] = int.Parse(array[i]);
            if (numbers[i] == 2)
            {
                count2++;
            }
            else if (numbers[i] == 3)
            {
                count3++;
            }
            else if (numbers[i] == 5)
            {
                count5++;
            }
        }
        if (count2 > 0)
        {
            Console.WriteLine("Ну что, студент, пора долг Родине отдать");
        }
        else if (count3 > 0 && count2 == 0)
        {
            Console.WriteLine("Прощай стипендия!");
        }
        else if (count3 == 0 && count2 == 0 && count5 != array.Length)
        {
            Console.WriteLine("Живи пока, через полгода увидимся");
        }
        else if (count5 == array.Length)
        {
            Console.WriteLine("О, отличник появился! На олимпиаду пойдешь");
        }
        Console.ReadLine();
    }
}