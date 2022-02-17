using System;

public class HW1
{
    public static long QueueTime(int[] customers, int n)
    {
        int[] now_customers = new int[n];
        int min_index = 0, max_index = 0;
        for (int i = 0; i < n; i++)
        {
            now_customers[i] = 0;
        }
        for (int i = 0; i < customers.Length; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (now_customers[min_index] > now_customers[j])
                    min_index = j;
            }
            now_customers[min_index] += customers[i];
        }
        for (int j = 0; j < n; j++)
        {
            if (now_customers[max_index] < now_customers[j])
                max_index = j;
        }
        return now_customers[max_index];
    }
}

public static class Program
{
    public static void Main()
    {
        int[] Customers = { 6, 3, 7, 1, 12, 4, 6 };
        Console.WriteLine(HW1.QueueTime(Customers, 3));
        Console.ReadLine();
    }
}

