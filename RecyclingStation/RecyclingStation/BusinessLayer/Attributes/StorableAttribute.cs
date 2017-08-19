namespace RecyclingStation.BusinessLayer.Attributes
{
    using System;
    using RecyclingStation.WasteDisposal.Attributes;

    public class StorableAttribute : DisposableAttribute
    {
        public StorableAttribute(Type correspondingStrategyType) : base(correspondingStrategyType)
        {
        }
    }
}
