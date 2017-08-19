using System;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var cmd = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var stack = new Stack<string>();

        while (cmd[0] != "END")
        {
            switch (cmd[0])
            {
                case "Push":
                    var elements = cmd.Skip(1).ToArray();
                    stack.Push(elements);
                    break;
                case "Pop": 
                    stack.Pop();
                    break;
            }

            cmd = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }
        foreach (var element in stack)
        {
            Console.WriteLine(element);
        }
        foreach (var element in stack)
        {
            Console.WriteLine(element);
        }
    }
}

