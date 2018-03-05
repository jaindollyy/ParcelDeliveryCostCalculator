using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcelDeliveryCalculator.Helpers
{ 
        public static class Validator
        {
            public static bool IsValidValue(int value)
            {
                return (value > 0);
            }

        }
}
