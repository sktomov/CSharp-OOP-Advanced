using System;
using System.Linq;

public class StartUp
{
    public static void Main(string[] args)
    {
        var inputLine = Console.ReadLine().Split(new[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        var frog = new Frog<int>(inputLine);
        Console.WriteLine(string.Join(", ", frog));
    }
}

