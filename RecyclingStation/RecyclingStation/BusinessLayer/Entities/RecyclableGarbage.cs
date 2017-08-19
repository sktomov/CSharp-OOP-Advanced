namespace RecyclingStation.BusinessLayer.Entities
{
    using RecyclingStation.BusinessLayer.Attributes;
    using RecyclingStation.BusinessLayer.Strategies;

    [Recycalble(typeof(RecycalbleGarbageStrategy))]
    public class RecyclableGarbage : Garbage
    {
        public RecyclableGarbage(string name,double weight, double volumePerKg) : base(name, weight, volumePerKg)
        {

        }
    }
}
