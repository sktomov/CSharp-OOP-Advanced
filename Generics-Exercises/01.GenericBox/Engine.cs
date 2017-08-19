
using System;

public class Engine
{
    private bool isRuning;
    
    public void Run()
    {
        this.isRuning = true;
        var box = new Box<string>();
        while (isRuning)
        {
            var input = Console.ReadLine().Split();
            switch (input[0])
            {
                case "END":
                    this.isRuning = false;
                    break;
                case "Add":
                    box.Add(input[1]);
                    break;
                case "Remove":
                    box.Remove(int.Parse(input[1]));
                    break;
                case "Contains":
                    Console.WriteLine(box.Contains(input[1]));
                    break;
                case "Swap":
                    box.Swap(int.Parse(input[1]), int.Parse(input[2]));
                    break;
                case "Greater":
                    Console.WriteLine(box.Greater(input[1]));
                    break;
                case "Max":
                    Console.WriteLine(box.Max());
                    break;
                case "Min":
                    Console.WriteLine(box.Min());
                    break;
                case "Sort":
                    box.Sort();
                    break;
                case "Print":
                    box.Print();
                    break;
                default:
                    break;
            }
        }
    }
}

