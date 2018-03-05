using System;
using System.Collections.Generic;
using System.Text;

namespace ParcelDeliveryCalculator
{
    /// <summary>
    ///  This is the interface for the strategy. , the concrete strategy classes need a “Calculate” function
    ///  which accepts a interger value (weight or volume) as per business rules and returns integer value as cost
    /// </summary>
    public interface IParcelCost
    {
        int Calculate(int weight_volume);
    }
}
