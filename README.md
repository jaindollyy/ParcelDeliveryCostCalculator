# ParcelDeliveryCostCalculator
Implementation of Strategy design pattern for the application to calculate cost of parcel delivery for different categories of parcel

INSTRUCTIONS

1) Download solution

2) Build solution to restore Nuget packages

3) Run the project (StartUp Project is ParcelDeliveryCalculator.Application)

4) Execute the Unit Tests project

SOLUTION DESCRIPTION

The solution consists of 3 projects.

a) ParcelDeliveryCalculator.Application is a console application to read and write the ouput to console.

b) ParcelDeliveryCalculator is a class library which has all the core business logic and strategy design pattern for calculating cost of different categories of parcel.

c) ParcelDeliveryCalculator.Tests contains five tests for Calculate function.

Receives four integer inputs to indicate the weight and size of a parcel for postage, and returns the cost of delivery. 
The user inputs are:
1.  Weight (kg)
2.  Height (cm)
3.  Width (cm)
4.  Depth (cm)
The rules for calculating the cost of delivery in order of priority:
Priority  Rule  Condition  Cost
1 (Highest)  Reject  If the weight exceeds 50kg N/A
2  Heavy Parcel  If the weight exceeds 10kg  $15 x Weight (kg)
3  Small Parcel  If the volume is less than 1500  $0.05 x Volume
4  Medium Parcel  If the volume is less than 2500  $0.04 x Volume
5 (Lowest) Large Parcel    $0.03 x Volume

Note: Volume is calculated by Height x Width x Depth.
Note: The rule matched with the highest priority should be used to calculate the cost of delivery.
Examples
1.  Enter Weight in kg: 10
Enter Height in cm: 20
Enter Width in cm: 5
Enter Depth: 20 
Category: Medium Parcel
Cost: $80
2.  Enter Weight in kg: 22
Enter Height in cm: 5
Enter Width in cm: 5
Enter Depth: 5
Category: Heavy Parcel
Cost: $330
3.  Enter Weight in kg: 2
Enter Height in cm: 3
Enter Width in cm: 10
Enter Depth: 12
Category: Small Parcel
Cost: $18
4.  Enter Weight in kg: 110
Enter Height in cm: 20
Enter Width in cm: 55
Enter Depth: 120
