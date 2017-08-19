namespace RecyclingStation.BusinessLayer.Attributes
{
    using RecyclingStation.WasteDisposal.Attributes;
    using System;

    public class RecycalbleAttribute : DisposableAttribute
    {
        public RecycalbleAttribute(Type correspondingStrategyType) : base(correspondingStrategyType)
        {
        }
    }
}
