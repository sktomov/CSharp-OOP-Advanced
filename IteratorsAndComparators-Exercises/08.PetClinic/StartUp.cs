using System;

public class StartUp
{
    static void Main()
    {
        var numberOfLines = int.Parse(Console.ReadLine());
        var engine = new Engine();
        engine.Run(numberOfLines);
    }
}

