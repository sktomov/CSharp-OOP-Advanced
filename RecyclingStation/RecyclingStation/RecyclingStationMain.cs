namespace RecyclingStation
{
    using System;
    using System.Collections.Generic;
    using RecyclingStation.BusinessLayer;
    using RecyclingStation.BusinessLayer.Contracts.Core;
    using RecyclingStation.BusinessLayer.Contracts.Factories;
    using RecyclingStation.BusinessLayer.Contracts.IO;
    using RecyclingStation.BusinessLayer.Core;
    using RecyclingStation.BusinessLayer.Factories;
    using RecyclingStation.BusinessLayer.IO;
    using RecyclingStation.WasteDisposal;
    using RecyclingStation.WasteDisposal.Interfaces;

    public class RecyclingStationMain
    {
        private static void Main()
        {
            IWriter writer = new Writer();
            IReader reader = new Reader();
            IStrategyHolder strategyHolder = new StrategyHolder(new Dictionary<Type, IGarbageDisposalStrategy>());
            IGarbageProcessor garbageProcessor = new GarbageProcessor(strategyHolder);
            IWasteFactory wasteFactory = new WasteFactory();

            IRecyclingStation recyclingStation = new Station(garbageProcessor, wasteFactory);
            Engine engine = new Engine(writer, reader, recyclingStation);

            engine.Run();
        }
    }
}
