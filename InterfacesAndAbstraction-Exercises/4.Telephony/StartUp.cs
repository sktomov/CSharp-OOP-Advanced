using System;

public class StartUp
{
    public static void Main()
    {
        string[] phoneNumbers = Console.ReadLine().Split();
        var smartphone = new Smartphone();
        foreach (var phoneNumber in phoneNumbers)
        {
            Console.WriteLine(smartphone.Call(phoneNumber));
        }
        string[] urls = Console.ReadLine().Split();
        foreach (var url in urls)
        {
            Console.WriteLine(smartphone.Browse(url));
        }
    }
}

