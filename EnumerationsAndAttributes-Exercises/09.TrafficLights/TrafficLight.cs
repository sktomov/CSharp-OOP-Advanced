using System;

public class TrafficLight
{
    public TrafficLight(string light)
    {
        this.Light = (Light)Enum.Parse(typeof(Light), light, true);
    }
    public Light Light { get; set; }

    public void ChangeLight()
    {
        var current = (int) this.Light;
        if (current == 2)
        {
            this.Light = 0;
        }
        else
        {
            this.Light++;
        }
    }

    public override string ToString()
    {
        return this.Light.ToString();
    }
}

