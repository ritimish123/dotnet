using System;

public class Program5
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        EvenNums(num);
    }

    private static void EvenNums(int num)
    {
        //throw new NotImplementedException();
        for (int i = 1; i <= num; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}