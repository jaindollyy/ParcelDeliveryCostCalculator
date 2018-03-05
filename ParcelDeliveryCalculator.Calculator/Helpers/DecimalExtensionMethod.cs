using System;

namespace ParcelDeliveryCalculator.Helpers
{
    public static class DecimalExtensionMethod
    {
        public static int RoundValue(decimal value)
        {
            return Convert.ToInt32( Math.Round(value, 0, MidpointRounding.AwayFromZero));
        }
    }
}
