using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecyclingStation.BusinessLayer.Strategies
{
    using RecyclingStation.WasteDisposal.Interfaces;

    public class BurnableGarbageStrategy : GarbageDisposalStrategy
    {
        protected override double CalculateEnergyBalance(IWaste garbage)
        {
            double energyProduced = garbage.CalculateWasteTotalVolume();
            double energyUsed = garbage.CalculateWasteTotalVolume() * 0.2;

            return energyProduced - energyUsed;
        }

        protected override double CalculateCapitalBalance(IWaste garbage)
        {
            return 0;
        }
    }
}
