public class Ferrari : ICar
{
    public Ferrari(string driverName)
    {
        this.DriverName = driverName;
        this.Model = "488-Spider";
    }
    public string DriverName { get; set; }
    public string Model { get;  private set; }
    public string Brake()
    {
        return "Brakes!";
    }

    public string Gas()
    {
        return "Zadu6avam sA!";
    }

    public override string ToString()
    {
        return $"{this.Model}/{this.Brake()}/{this.Gas()}/{this.DriverName}";
    }
}

