using System;

public class StartUp
{
    static void Main()
    {
        var radius = double.Parse(Console.ReadLine());
        IDrawable cirlce = new Circle(radius);

        var width = int.Parse(Console.ReadLine());
        var height = int.Parse(Console.ReadLine());
        IDrawable rectange = new Rectangle(width, height);
        
        cirlce.Draw();
        rectange.Draw();
    }
}

