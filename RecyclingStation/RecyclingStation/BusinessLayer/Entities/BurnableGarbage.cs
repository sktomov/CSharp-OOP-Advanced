namespace RecyclingStation.BusinessLayer.Entities
{
    using RecyclingStation.BusinessLayer.Attributes;
    using RecyclingStation.BusinessLayer.Strategies;

    [Burnable(typeof(BurnableGarbageStrategy))]
    public class BurnableGarbage : Garbage
    {
        public BurnableGarbage(string name, double weight, double volumePerKg) : base(name, weight, volumePerKg)
        {

        }
    }
}
