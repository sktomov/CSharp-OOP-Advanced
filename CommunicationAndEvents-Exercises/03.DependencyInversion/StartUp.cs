using System;

public class StartUp
{
    public static void Main()
    {
        PrimitiveCalculator calculator = new PrimitiveCalculator();

        string[] inputLine = Console.ReadLine().Split();

        while (inputLine[0] != "End")
        {
            if (inputLine[0] == "mode")
            {
                calculator.changeStrategy(char.Parse(inputLine[1]));
            }
            else
            {
                int firstOperand = int.Parse(inputLine[0]);
                int secondOperand = int.Parse(inputLine[1]);
                Console.WriteLine(calculator.performCalculation(firstOperand, secondOperand));
            }
            inputLine = Console.ReadLine().Split();
        }
    }
}

