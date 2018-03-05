using System;
using System.Collections.Generic;
using System.Text;
using ParcelDeliveryCalculator.Helpers;

namespace ParcelDeliveryCalculator
{
    /// <summary>
    /// The concrete strategy to calculate cost of parcel, for medium parcel category
    /// </summary>
    public class MediumParcel : IParcelCost
    {
        public const decimal val = 0.04m;

        int IParcelCost.Calculate(int volume)
        {
            return DecimalExtensionMethod.RoundValue(val * volume);
        }
    }
}
