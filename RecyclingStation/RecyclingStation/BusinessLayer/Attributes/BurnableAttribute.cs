namespace RecyclingStation.BusinessLayer.Attributes
{
    using System;
    using RecyclingStation.WasteDisposal.Attributes;

    public class BurnableAttribute : DisposableAttribute
    {
        public BurnableAttribute(Type correspondingStrategyType) : base(correspondingStrategyType)
        {
        }
    }
}
