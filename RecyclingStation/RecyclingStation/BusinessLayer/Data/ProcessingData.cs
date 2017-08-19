namespace RecyclingStation.BusinessLayer.Data
{
    using RecyclingStation.WasteDisposal.Interfaces;

    public class ProcessingData : IProcessingData
    {
        private double energyBalance;
        private double capitalBalance;

        public ProcessingData(double energyBalance, double capitalBalance)
        {
            this.EnergyBalance = energyBalance;
            this.CapitalBalance = capitalBalance;
        }

        public double EnergyBalance
        {
            get => this.energyBalance;
            set => this.energyBalance = value;
        }

        public double CapitalBalance
        {
            get => this.capitalBalance;
            set => this.capitalBalance = value;
        }
    }
}
