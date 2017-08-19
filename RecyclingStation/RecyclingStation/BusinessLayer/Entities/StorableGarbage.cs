namespace RecyclingStation.BusinessLayer.Entities
{
    using RecyclingStation.BusinessLayer.Attributes;
    using RecyclingStation.BusinessLayer.Strategies;

    [Storable(typeof(StorableGarbageStrategy))]
    public class StorableGarbage : Garbage
    {
        public StorableGarbage(string name, double weight, double volumePerKg) : base(name, weight, volumePerKg)
        {

        }
    }
}
