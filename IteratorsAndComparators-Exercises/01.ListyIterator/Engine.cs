using System;
using System.Linq;

public  class Engine
{
    private bool isRuninig = true;
    private ListyIterator<string> listyIterator;

    public  void Run()
    {
        while (this.isRuninig)
        {
            var inputLine = Console.ReadLine().Split();
            switch (inputLine[0])
            {
                case "Create":
                    var args = inputLine.Skip(1).ToArray();
                    this.listyIterator = new ListyIterator<string>(args);
                    break;
                case "Print":
                    this.listyIterator.Print();
                    break;
                case "Move":
                    Console.WriteLine(this.listyIterator.Move());
                    break;
                case "HasNext":
                    Console.WriteLine(this.listyIterator.HasNext());
                    break;
                case "PrintAll":
                    this.listyIterator.PrintAll();
                    break;
                case "END":
                    this.isRuninig = false;
                    break;
                default:
                    break;
            }
        }
    }
}

