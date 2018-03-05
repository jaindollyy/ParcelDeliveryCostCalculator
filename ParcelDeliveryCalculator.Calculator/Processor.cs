using System;
using System.Collections.Generic;
using System.Text;
using ParcelDeliveryCalculator.Entities;
using ParcelDeliveryCalculator.Enums;
using ParcelDeliveryCalculator.Helpers;

namespace ParcelDeliveryCalculator
{
    public class Processor
    {
        /// <summary>
        /// Get and validate inputs and create object Parcel Dimension to pass for cost calculation
        /// </summary>
        /// <param name="weight"></param>
        /// <param name="height"></param>
        /// <param name="width"></param>
        /// <param name="depth"></param>
        /// <returns></returns>
        public static Tuple<string, string> GetParcelDeliveryCost(int weight, int height, int width, int depth)
        {
            if (!Validator.IsValidValue(weight) || !Validator.IsValidValue(height) || !Validator.IsValidValue(width) || !Validator.IsValidValue(depth))
            {
                throw new System.Exception("Values cannot be less than 0");
            }

            var parcelDimension = new ParcelDimension(weight, height, width, depth);

            return CalculateParcelDeliveryCost(parcelDimension);

        } 

        /// <summary>
        /// Implementaion of business rules to get parcel category and calculate parcel delivery cost
        /// </summary>
        /// <param name="parcelDimension"></param>
        /// <returns></returns>

        private static Tuple<string, string> CalculateParcelDeliveryCost(ParcelDimension parcelDimension )
        {
            if (parcelDimension.Weight > 50)
                return Tuple.Create(CategoryTypes.Rejected.ToString(), "N/A");


            using (Calculator calculator = new Calculator())
            {
                int cost = 0;
                string category = string.Empty;

                if (parcelDimension.Weight > 10)
                {
                    cost = calculator.Calculate(parcelDimension.Weight, new HeavyParcel());
                    category = CategoryTypes.Heavy.ToString();

                }
                else if (parcelDimension.Volume < 1500)
                {
                    cost = calculator.Calculate(parcelDimension.Volume, new SmallParcel());
                    category = CategoryTypes.Small.ToString();
                }
                else if (parcelDimension.Volume < 2500)
                {
                    cost = calculator.Calculate(parcelDimension.Volume, new MediumParcel());
                    category = CategoryTypes.Medium.ToString();
                }
                else
                {
                    cost = calculator.Calculate(parcelDimension.Volume, new LargeParcel());
                    category = CategoryTypes.Large.ToString();
                }

                return Tuple.Create(category + " Parcel", "$" + cost.ToString());

            }
        }
    }
}
