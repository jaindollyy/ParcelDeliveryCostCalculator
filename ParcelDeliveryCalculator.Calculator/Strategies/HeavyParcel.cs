using System;
using System.Collections.Generic;
using System.Text;
using ParcelDeliveryCalculator.Helpers;

namespace ParcelDeliveryCalculator
{
    /// <summary>
    /// The concrete strategy to calculate cost of parcel, for heavy parcel category
    /// </summary>
    public class HeavyParcel : IParcelCost
    {
        public const int val = 15;

        int IParcelCost.Calculate(int weight)
        {
            return DecimalExtensionMethod.RoundValue(val * weight);
        }
    }
}
