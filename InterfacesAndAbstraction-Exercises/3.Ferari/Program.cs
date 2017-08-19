using System;

public class Program
{
    public static void Main()
    {
        string driverName = Console.ReadLine().Trim();
        var ferrari = new Ferrari(driverName);
        Console.WriteLine(ferrari);
    }
}

