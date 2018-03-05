using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParcelDeliveryCalculator.Entities;


namespace ParcelDeliveryCalculator.Tests
{
    [TestClass]
    public class CalculatorTests
    {
            
        [TestMethod]
        public void RejectedParcelTest()
        {

            ParcelDimension parcelDimension = new ParcelDimension(110, 20, 55, 120);
 
            var actualResult = Processor.GetParcelDeliveryCost(parcelDimension.Weight,parcelDimension.Height,parcelDimension.Width,parcelDimension.Depth);

            string expectedResult =  "N/A" ;

            Assert.AreEqual(expectedResult, actualResult.Item2);
        }

        [TestMethod]
        public void HeavyParcelTest()
        {

            ParcelDimension parcelDimension = new ParcelDimension(22, 5, 5, 5);
                       
            int expectedResult = 330;

            Calculator calculator = new Calculator();

            int actualResult = calculator.Calculate(parcelDimension.Weight, new HeavyParcel());
           
            Assert.AreEqual(expectedResult, actualResult);
        }        

        [TestMethod]
        public void LargeParcelTest()
        {
            ParcelDimension parcelDimension = new ParcelDimension(8, 20, 5, 50);

            int expectedResult = 150;

            Calculator calculator = new Calculator();

            int actualResult = calculator.Calculate(parcelDimension.Volume, new LargeParcel());

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void MediumParcelTest()
        {
            ParcelDimension parcelDimension = new ParcelDimension(10, 20, 5, 20);
          
            int expectedResult = 80;

            Calculator calculator = new Calculator();

            int actualResult = calculator.Calculate(parcelDimension.Volume, new MediumParcel());

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void SmallParcelTest()
        {

            ParcelDimension parcelDimension = new ParcelDimension(2, 3, 10, 12);

           int expectedResult = 18;

            Calculator calculator = new Calculator();

            int actualResult = calculator.Calculate(parcelDimension.Volume, new SmallParcel());

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
