using System;
using ParcelDeliveryCalculator;

namespace ParcelDeliveryCostCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {             
                do
                {
                    Console.Clear();

                    int Weight, Height, Width, Depth;

                    Console.WriteLine(" Enter Weight in kg: ");
                    Weight = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(" Enter Height in cm: ");
                    Height = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(" Enter Width in cm: ");
                    Width = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(" Enter Depth: ");
                    Depth = Convert.ToInt32(Console.ReadLine());

                    //This is a call to main function which has all business rules and strategy pattern implemenation
                    //to calculate and return the cost as per category of parcel

                    var output = Processor.GetParcelDeliveryCost(Weight, Height, Width, Depth);
                    Console.WriteLine("\n Category: {0} \n Cost: {1} ", output.Item1, output.Item2);


                    Console.WriteLine("\n\n Press escape key to exit... ");

                } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

                Environment.Exit(0);
            
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadKey();
            }
        }
    }
}
