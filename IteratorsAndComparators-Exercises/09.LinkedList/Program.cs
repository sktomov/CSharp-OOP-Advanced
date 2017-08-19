using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        var list = new LinkedList<int>();
        var numberOfLines = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfLines; i++)
        {
            var cmd = Console.ReadLine().Split();
            switch (cmd[0])
            {
                case "Add":
                    list.AddLast(int.Parse(cmd[1]));
                    break;
                case "Remove":
                    list.Remove(int.Parse(cmd[1]));
                    break;
            }
        }
        Console.WriteLine(list.Count);
        Console.WriteLine(string.Join(" ", list));
    }
}

