using System;
using System.Collections.Generic;
using System.Text;
using ParcelDeliveryCalculator.Helpers;

namespace ParcelDeliveryCalculator
{
    /// <summary>
    /// The concrete strategy to calculate cost of parcel, for small parcel category
    /// </summary>
    public class SmallParcel : IParcelCost
    {
        public const decimal val = 0.05m;

        int IParcelCost.Calculate(int volume)
        {
            return DecimalExtensionMethod.RoundValue(val * volume);
        }
    }
}
