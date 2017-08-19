using System.Text;

public class Tesla : IElectricCar
{
    public Tesla(string model, string color, int numberOfBateries)
    {
        this.Model = model;
        this.Color = color;
        this.NumberOfBateries = numberOfBateries;
    }
    public string Model { get; set; }
    public string Color { get; set; }
    public int NumberOfBateries { get; set; }
    public string Start()
    {
        return "Engine start";
    }

    public string Stop()
    {
        return "Breaaak!";
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{this.Color} {this.GetType().Name} {this.Model} with {this.NumberOfBateries} Batteries");
        sb.AppendLine(this.Start());
        sb.AppendLine(this.Stop());
        return sb.ToString().Trim();
    }
}

