using System.Collections.Generic;

public class PrimitiveCalculator
{
    private IStrategy strategy;

    private Dictionary<char, IStrategy> strategies = new Dictionary<char, IStrategy>
    {
        {'+', new AdditionStrategy()},
        {'-', new SubtractionStrategy()},
        {'*', new MultiplyStrategy()},
        {'/', new DivideStrategy()},
    };

    public PrimitiveCalculator()
    {
        this.strategy = this.strategies['+'];
    }

    public void changeStrategy(char @operator)
    {
        this.strategy = this.strategies[@operator];
    }

    public int performCalculation(int firstOperand, int secondOperand)
    {
        return this.strategy.Calculate(firstOperand, secondOperand);
    }
}

