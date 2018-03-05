using System;
using System.Collections.Generic;
using System.Text;
using ParcelDeliveryCalculator.Helpers;

namespace ParcelDeliveryCalculator
{
    /// <summary>
    /// The concrete strategy to calculate cost of parcel, for large parcel category
    /// </summary>
    public class LargeParcel : IParcelCost
    {
        public const decimal val = 0.03m;

        int IParcelCost.Calculate (int volume)
        {
            return DecimalExtensionMethod.RoundValue(val * volume);
        }
    }
}
