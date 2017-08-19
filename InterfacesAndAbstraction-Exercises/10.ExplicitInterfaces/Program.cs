using System;
using System.Text;

public class Program
{
    static void Main()
    {
        var inputLine = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        var sb = new StringBuilder();
        while (inputLine[0] != "End")
        {
            var name = inputLine[0];
            sb.AppendLine(name);
            sb.AppendLine($"Mr/Ms/Mrs {name}");
            inputLine = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }
        Console.WriteLine(sb.ToString().Trim());
    }
}

