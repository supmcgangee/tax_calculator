using System;

namespace TaxCalculator
{
    public class PetrolTaxCalculator : TaxCalculator
    {
        public override int CalculateTax(Vehicle vehicle)
        {
            int[] emissionThresholds =
            {
                50,
                75,
                90,
                100,
                110,
                130,
                150,
                170,
                190,
                225,
                255
            };

            int[] taxAmounts =
            {
                10,
                25,
                105,
                125,
                145,
                165,
                205,
                515,
                830,
                1240,
                1760
            };

            if (vehicle.Co2Emissions == 0)
            {
                return 0;
            }

            for (var i = 0; i < emissionThresholds.Length; i++)
            {
                
                if (vehicle.Co2Emissions <= emissionThresholds[i])
                {
                    return taxAmounts[i];
                }
            }

            return 2070;
        }
    }
}
