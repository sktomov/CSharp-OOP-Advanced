namespace RecyclingStation.BusinessLayer
{
    using RecyclingStation.BusinessLayer.Contracts.Core;
    using RecyclingStation.BusinessLayer.Contracts.Factories;
    using RecyclingStation.WasteDisposal.Interfaces;

    public class Station : IRecyclingStation
    {
        private IGarbageProcessor garbageProcessor;
        private IWasteFactory wasteFactory;
        private double capitalBalance;
        private double energyBalance;
        private double minimumEnergyBalance;
        private double minimumCapitalBalance;
        private bool changedRequerment;
        private string typeOfGarbage;

        public Station(IGarbageProcessor garbageProcessor, IWasteFactory wasteFactory)
        {
            this.garbageProcessor = garbageProcessor;
            this.wasteFactory = wasteFactory;
        }
        
        public string ProcessGarbage(string name, double weight, double volumePerKg, string type)
        {
            if (this.changedRequerment)
            {
                if (this.typeOfGarbage == type)
                {
                    bool requermentsAreSatisfied = this.capitalBalance >= this.minimumCapitalBalance &&
                                                   this.energyBalance >= this.minimumEnergyBalance;
                    if (!requermentsAreSatisfied)
                    {
                        return $"Processing Denied!";
                    }
                }
            }

            IWaste waste = this.wasteFactory.Create(name, weight, volumePerKg, type);

            IProcessingData processedData = this.garbageProcessor.ProcessWaste(waste);

            this.capitalBalance += processedData.CapitalBalance;
            this.energyBalance += processedData.EnergyBalance;

            return $"{waste.Weight:f2} kg of {waste.Name:f2} successfully processed!";
        }

        public string ChangeManagementRequirement(double minimumEnergyBalance, double minimumCapitalBalance, string typeOfGarbage)
        {
            this.minimumEnergyBalance = minimumEnergyBalance;
            this.minimumCapitalBalance = minimumCapitalBalance;
            this.typeOfGarbage = typeOfGarbage;
            this.changedRequerment = true;
            return $"Management requirement changed!";
        }

        public string Status()
        {
            return $"Energy: {this.energyBalance:f2} Capital: {this.capitalBalance:f2}";
        }
    }
}
