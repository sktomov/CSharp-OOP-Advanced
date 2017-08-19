using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main()
    {
        var intruders = new List<string>();
        ReadInput(intruders);
        var fakeId = Console.ReadLine();
        fakeId = "/" + fakeId;
        RemoveFakeIds(intruders, fakeId);
        Console.WriteLine(string.Join(Environment.NewLine, intruders));
    }

    private static void RemoveFakeIds(List<string> intruders, string fakeId)
    {
        intruders.RemoveAll(i => !i.EndsWith(fakeId));
    }

    private static void ReadInput(List<string> intruders)
    {
        var inputLine = Console.ReadLine().Split();
        while (inputLine[0] != "End")
        {
            if (inputLine.Length == 3)
            {
                intruders.Add(inputLine[2]);
            }
            else if (inputLine.Length == 5)
            {
                intruders.Add(inputLine[4]);
            }
            inputLine = Console.ReadLine().Split();
        }
    }
}

