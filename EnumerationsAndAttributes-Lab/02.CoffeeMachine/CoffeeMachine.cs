using System;
using System.Collections.Generic;

public class CoffeeMachine
{
    private int coins;
    private List<CoffeeType> sales;

    public CoffeeMachine()
    {
        this.sales = new List<CoffeeType>();
    }

    public IEnumerable<CoffeeType> CoffeesSold => this.sales;

    public void BuyCoffee(string size, string type)
    {
        CoffeePrice coffeePrice;
        var isValid = Enum.TryParse(size, true, out coffeePrice);

        CoffeeType coffeeType;
        var isValidType = Enum.TryParse(type, true, out coffeeType);

        var moneyToBuy = (int) coffeePrice;
        if (moneyToBuy > this.coins || !isValid ||!isValidType)
        {
            return;
        }
        this.sales.Add(coffeeType);
        this.coins = 0;
    }

    public void InsertCoin(string coin)
    {
        this.coins += (int) Enum.Parse(typeof(Coin), coin);
    }
}

