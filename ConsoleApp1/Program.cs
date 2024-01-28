using System;

class Program
{
    static void Main()
    {
        int startI = 1;
        int endI = 3;
        int startK = 1;
        int endK = 10;
        double x = 5;
        double sum = 0;

        for (int i = startI; i <= endI; i++)
        {
            for (int k = startK; k <= endK; k++)
            {
                sum += x / Math.Sin(k);
            }
        }

        Console.WriteLine("Сумма ряда: " + sum);
    }
}