using AssignmentSession6_OOP.interfaces;
using AssignmentSession6_OOP.shipments;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AssignmentSession6_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 01 
            //DeliveryAddress address1 = new DeliveryAddress();
            //address1.City = "Giza";
            //DeliveryAddress address2 = address1;
            //Console.WriteLine(address1.City);//Giza
            //Console.WriteLine(address2.City);//Giza
            //address1.City = "cairo";
            //Console.WriteLine(address1.City);//cairo
            //Console.WriteLine(address2.City);//Giza , because DeliveryAddress is struct (value type)
            //                                 //, so address2 is an independent copy. 
            //Console.WriteLine("===========================");
            //Customer customer1 = new Customer();
            //customer1.Name = "ahmed";
            //Customer customer2 = customer1;
            //Console.WriteLine(customer1.Name);//ahmed
            //Console.WriteLine(customer2.Name);//ahmed
            //customer1.Name = "ali";
            //Console.WriteLine(customer1.Name);//ali
            //Console.WriteLine(customer2.Name);//ali ,  beacuse Customer is class (reference type) ,
            //Modifying the object through one variable will affect the other so customer2 will also change to ali
            #endregion

            #region Part 02
            //DeliveryAddress address1 = new DeliveryAddress("fysel", "hassan mohamed", 55);
            //string fullAddress = address1.GetFullAddress();
            //Console.WriteLine(fullAddress); // 55-hassan mohamed-fysel
            //DeliveryAddress address2 = address1;
            //address1.City = "cairo";
            //Console.WriteLine(address1.GetFullAddress()); // 55-hassan mohamed-cairo
            //Console.WriteLine(address2.GetFullAddress()); // 55-hassan mohamed-fysel
            //Console.WriteLine("=================");

            //// a. Create a DeliveryCenter
            //DeliveryCenter center = new DeliveryCenter();

            //// b & c. Read data for 3 shipments and add them to DeliveryCenter
            //for (int i = 1; i <= 3; i++)
            //{

            //    Console.WriteLine($"Enter Shipment {i} Data");
            //    Console.Write("Tracking Code: ");
            //    string trackingCode = Console.ReadLine();

            //    Console.Write("Description: ");
            //    string description = Console.ReadLine();

            //    Console.Write("Weight: ");
            //    double weight = double.Parse(Console.ReadLine());

            //    Console.Write("Delivery Fee: ");
            //    decimal deliveryFee = decimal.Parse(Console.ReadLine());

            //    Console.Write("City: ");
            //    string city = Console.ReadLine();

            //    Console.Write("Street: ");
            //    string street = Console.ReadLine();

            //    Console.Write("Building Number: ");
            //    int buildingNumber = int.Parse(Console.ReadLine());

            //    // Create DeliveryAddress and Shipment objects
            //    DeliveryAddress address = new DeliveryAddress(street, city, buildingNumber);
            //    Shipment shipment = new Shipment(trackingCode, description, weight, deliveryFee, address);
            //    // Add to center
            //    if (center.AddShipment(shipment))
            //    {
            //        Console.WriteLine("\nShipment added successfully.\n");
            //    }
            //}
            //// d. Print the three shipments using the integer indexer
            //Console.WriteLine("--- All Shipments");
            //for (int n = 0; n < 3; n++)
            //{
            //    // Using integer indexer center[i]

            //    Shipment s = center[n];

            //    // Print information
            //    Console.WriteLine($"Tracking Code: {s.TrackingCode}");
            //    Console.WriteLine($"Description: {s.Description}");
            //    Console.WriteLine($"Weight: {s.Weight} KG");
            //    Console.WriteLine($"Delivery Fee: {s.DeliveryFee} EGP");
            //    Console.WriteLine($"Destination: {s.Destination.GetFullAddress()}");
            //    Console.WriteLine($"Estimated Cost: {s.EstimatedCost} EGP\n");
            //}

            //// e & f & g. Search for shipment using the string indexer
            //Console.Write("Enter a tracking code to search: ");

            //string searchCode = Console.ReadLine();

            //Shipment searchedShipment = center[searchCode];

            //if (!string.IsNullOrEmpty(searchedShipment.TrackingCode))
            //{
            //    Console.WriteLine($"Shipment found: {searchedShipment.TrackingCode} - {searchedShipment.Description}\n");
            //}
            //else
            //{
            //    Console.WriteLine("Shipment not found.\n");
            //}

            //// h. Demonstrate DeliveryAddress struct copy behavior (Value Type Concept)
            //Console.WriteLine("--- Struct Copy Test ---");
            //DeliveryAddress originalAddress = new DeliveryAddress("Tahrir Street", "Cairo", 15);
            //DeliveryAddress copiedAddress = originalAddress;


            //copiedAddress.Street = "Makram Ebeid Street";
            //copiedAddress.BuildingNumber = 20;

            //Console.WriteLine($"Original Address: {originalAddress.GetFullAddress()}");
            //Console.WriteLine($"Copied Address: {copiedAddress.GetFullAddress()}");

            #endregion





            #region Part 01 : Theoretical Questions /  Question 1
            //(a):
            // A class is refrance type , while a struct s a value type. classes are generally used to represent complex objects , while structs are typically used for small and smple data types.
            // classes support inhertance and polymorphism, whreas structs do not support inheritance. 

            //(b)

            // Classes are more sutable for large applications becuase they are designed to represent complex objects with data and behanior.
            // They support important OOP concepts such as inheritance, polymorphism, and encapsulation, which make the code more flexible, maintainable.

            #endregion

            #region Question 2
            // a- Shipment is the parent (base) class.
            // b- ExpressShipment is the child class
            // c- The TrackingCode property is inherited from the Shipment class
            // d- Inheritance is better because: 
            //    Code Reusability  Maintainability 
            #endregion
            #region Part 02 : Practical Questions /  Question 1


            #endregion




            #region Part 02 : Practical Questions
            //1.Create a DeliveryCenter.
            //2.Read the center name from the user.
            //3.Create one StandardShipment.
            //4.Create one ExpressShipment.
            //5.Create one InternationalShipment.
            //6.Read all shipment data from the user.

            //            DeliveryCenter center = new DeliveryCenter();

            //            Console.Write("Enter Center Name: ");

            //            center.centerName = Console.ReadLine();

            //            Console.WriteLine("\nEnter Standard Shipment Data:");

            //            //StandardShipment

            //            Console.Write("Tracking Code:");

            //            string StandardTrackingCode = Console.ReadLine();

            //            Console.Write("Description:");

            //            string StandardDescription = Console.ReadLine();

            //            Console.Write("Weight:");

            //            decimal StandardWeight = decimal.Parse(Console.ReadLine());

            //            Console.Write("Delivery Fee:");

            //            decimal StandardDeliveryFee = decimal.Parse(Console.ReadLine());

            //            Console.Write("City: ");
            //            string standardCity = Console.ReadLine();

            //            Console.Write("Street: ");
            //            string standardStreet = Console.ReadLine();

            //            Console.Write("Building Number: ");
            //            int standardBuildingNumber = int.Parse(Console.ReadLine());

            //            DeliveryAddress standardAddress = new DeliveryAddress
            //            {
            //                City = standardCity,
            //                Street = standardStreet,
            //                BuildingNumber = standardBuildingNumber
            //            };
            //            StandardShipment standard = new StandardShipment(
            //                StandardTrackingCode, StandardDescription, StandardWeight, StandardDeliveryFee, standardAddress
            //                );


            //            //ExpressShipment

            //            Console.WriteLine("\nEnter Express Shipment Data:");

            //            Console.Write("Tracking Code:");

            //            string expressTrackingCode = Console.ReadLine();

            //            Console.Write("Description:");

            //            string expressDescription = Console.ReadLine();

            //            Console.Write("Weight:");

            //            decimal expressWeight = decimal.Parse(Console.ReadLine());

            //            Console.Write("Delivery Fee:");

            //            decimal expressDeliveryFee = decimal.Parse(Console.ReadLine());

            //            Console.Write("Extra Fee:");

            //            decimal expressExtraFee = decimal.Parse(Console.ReadLine());


            //            Console.Write("City: ");
            //            string expressCity = Console.ReadLine();

            //            Console.Write("Street: ");
            //            string expressStreet = Console.ReadLine();

            //            Console.Write("Building Number: ");
            //            int expressBuildingNumber = int.Parse(Console.ReadLine());

            //            DeliveryAddress expressAddress = new DeliveryAddress
            //            {
            //                City = expressCity,
            //                Street = expressStreet,
            //                BuildingNumber = expressBuildingNumber
            //            };
            //            ExpressShipment express = new ExpressShipment(
            //    expressTrackingCode,
            //    expressDescription,
            //    expressWeight,
            //    expressDeliveryFee,
            //    expressAddress,
            //    expressExtraFee
            //);


            //            //InternationalShipment

            //            Console.WriteLine("\nEnter International Shipment Data:");

            //            Console.Write("Tracking Code:");

            //            string internationalTrackingCode = Console.ReadLine();

            //            Console.Write("Description:");

            //            string internationalDescription = Console.ReadLine();

            //            Console.Write("Weight:");

            //            decimal internationalWeight = decimal.Parse(Console.ReadLine());

            //            Console.Write("Delivery Fee:");

            //            decimal internationalDeliveryFee = decimal.Parse(Console.ReadLine());

            //            Console.Write("destinationCountry:");

            //            string internationalDestinationCountry = Console.ReadLine();

            //            Console.Write("Customs Fee:");

            //            decimal internationalCustomsFee = decimal.Parse(Console.ReadLine());


            //            Console.Write("City: ");
            //            string internationalCity = Console.ReadLine();

            //            Console.Write("Street: ");
            //            string internationalStreet = Console.ReadLine();

            //            Console.Write("Building Number: ");
            //            int internationalBuildingNumber = int.Parse(Console.ReadLine());

            //            DeliveryAddress internationalAddress = new DeliveryAddress
            //            {
            //                City = internationalCity,
            //                Street = internationalStreet,
            //                BuildingNumber = internationalBuildingNumber
            //            };
            //            InternationalShipment international = new InternationalShipment(
            //    internationalTrackingCode,
            //    internationalDescription,
            //    internationalWeight,
            //    internationalDeliveryFee,
            //    internationalAddress,
            //    internationalDestinationCountry,
            //    internationalCustomsFee
            //);
            //            //7. Add the shipments to the delivery center.
            //            center.AddShipment(standard);
            //            Console.WriteLine("Shipment Added Successfully.");

            //            center.AddShipment(express);
            //            Console.WriteLine("Shipment Added Successfully.");

            //            center.AddShipment(international);
            //            Console.WriteLine("Shipment Added Successfully.\n");

            //            //8. Print all shipments.

            //            center.PrintAllShipments();

            //            //9. Search for a shipment using the existing tracking code indexer.

            //            Console.Write("\nEnter Tracking Code to Search: ");
            //            string searchCode = Console.ReadLine();
            //            Shipment searchShipment = center[searchCode];

            //            if (searchShipment != null)
            //            {
            //                Console.WriteLine("\nShipment Found:");
            //                searchShipment.PrintShipment();
            //            }
            //            else
            //            {
            //                Console.WriteLine("Shipment Not Found.");
            //            }

            //            //10. Remove one shipment using its tracking code.

            //            Console.Write("\nEnter Tracking Code to Remove: ");

            //            string removeCode = Console.ReadLine();

            //            bool removed = center.RemoveShipment(removeCode);

            //            if (removed)
            //            {
            //                Console.WriteLine("Shipment removed successfully.");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Shipment not found.");
            //            }

            //            //11. Print the remaining shipments.

            //            Console.WriteLine("\nRemaining Shipments:");
            //            center.PrintAllShipments();

            #endregion

            #region Part 01 : Theoretical Questions /  Question 1 (OOP3)
            //Q1

            // (a): Method overloading occurs when multiple methods have the same name ut different prameteter lists (order/count/type) , it is resolved at compile time
            //       Method overriing occurs then derived class provides a new implemenation for vitual or abstract method inherited from a base class, it is resolved at runtime

            // (b): Static Binding means that the method to be excuted is determind at compile time. it s commonly associated with method overloading.
            //       Dynamic Binding means that eht method to be exeuted is determined at runtime ased on the actual oject type. It is commonly associated with method overriding and polymorphism.


            //Q2 

            // (a): The sealed keyword pervents a class from being inherited. A sealed class cannot be used as a base class.

            // (b): A sealed class pervents other classes from inheriting from it, while a sealed method preents derived classes from overriding that specfic method.

            // (c): No. A sealed method cannot be overriding by further derived classes because the sealed keyword pervents any further overriding if that method.


            #endregion
            #region Part 02 : Practical Questions / (OOP3)

            //Create a Driver.

            //Console.Write("Enter Driver Name: ");
            //string driverName = Console.ReadLine();
            //Driver driver = new Driver(driverName);

            ////  b. Create a DeliveryCenter.
            //// c.Assign the Driver to the DeliveryCenter.

            //DeliveryCenter center = new DeliveryCenter();
            //Console.Write("Enter Center Name: ");
            //center.centerName = Console.ReadLine();
            //center.Driver = driver;

            ////Create one StandardShipment.

            //Console.WriteLine("\nEnter Standard Shipment Data:");
            //Console.Write("Tracking Code: ");
            //string stdCode = Console.ReadLine();
            //Console.Write("Description: ");
            //string stdDesc = Console.ReadLine();
            //Console.Write("Weight: ");
            //decimal stdWeight = decimal.Parse(Console.ReadLine());
            //Console.Write("Delivery Fee: ");
            //decimal stdFee = decimal.Parse(Console.ReadLine());
            //Console.Write("City: ");
            //string stdCity = Console.ReadLine();
            //Console.Write("Street: ");
            //string stdStreet = Console.ReadLine();
            //Console.Write("Building Number: ");
            //int stdBuilding = int.Parse(Console.ReadLine());

            //DeliveryAddress stdAddress = new DeliveryAddress
            //{
            //    City = stdCity,
            //    Street = stdStreet,
            //    BuildingNumber = stdBuilding
            //};

            //StandardShipment standard = new StandardShipment(stdCode, stdDesc, stdWeight, stdFee, stdAddress);

            //// Create one ExpressShipment.
            //Console.WriteLine("\nEnter Express Shipment Data:");
            //Console.Write("Tracking Code: ");
            //string expCode = Console.ReadLine();
            //Console.Write("Description: ");
            //string expDesc = Console.ReadLine();
            //Console.Write("Weight: ");
            //decimal expWeight = decimal.Parse(Console.ReadLine());
            //Console.Write("Delivery Fee: ");
            //decimal expFee = decimal.Parse(Console.ReadLine());
            //Console.Write("Extra Fee: ");
            //decimal expExtraFee = decimal.Parse(Console.ReadLine());
            //Console.Write("City: ");
            //string expCity = Console.ReadLine();
            //Console.Write("Street: ");
            //string expStreet = Console.ReadLine();
            //Console.Write("Building Number: ");
            //int expBuilding = int.Parse(Console.ReadLine());

            //DeliveryAddress expAddress = new DeliveryAddress
            //{
            //    City = expCity,
            //    Street = expStreet,
            //    BuildingNumber = expBuilding
            //};

            //ExpressShipment express = new ExpressShipment(expCode, expDesc, expWeight, expFee, expAddress, expExtraFee);

            //// Create one InternationalShipment.

            //Console.WriteLine("\nEnter International Shipment Data:");
            //Console.Write("Tracking Code: ");
            //string intCode = Console.ReadLine();
            //Console.Write("Description: ");
            //string intDesc = Console.ReadLine();
            //Console.Write("Weight: ");
            //decimal intWeight = decimal.Parse(Console.ReadLine());
            //Console.Write("Delivery Fee: ");
            //decimal intFee = decimal.Parse(Console.ReadLine());
            //Console.Write("Destination Country: ");
            //string intCountry = Console.ReadLine();
            //Console.Write("Customs Fee: ");
            //decimal intCustomsFee = decimal.Parse(Console.ReadLine());
            //Console.Write("City: ");
            //string intCity = Console.ReadLine();
            //Console.Write("Street: ");
            //string intStreet = Console.ReadLine();
            //Console.Write("Building Number: ");
            //int intBuilding = int.Parse(Console.ReadLine());

            //DeliveryAddress intAddress = new DeliveryAddress
            //{
            //    City = intCity,
            //    Street = intStreet,
            //    BuildingNumber = intBuilding
            //};

            //InternationalShipment international = new InternationalShipment(intCode, intDesc, intWeight, intFee, intAddress, intCountry, intCustomsFee);

            //// g. Add all shipments to the DeliveryCenter.

            //center.AddShipment(standard);
            //Console.WriteLine("\nShipment Added Successfully.");
            //center.AddShipment(express);
            //Console.WriteLine("Shipment Added Successfully.");
            //center.AddShipment(international);
            //Console.WriteLine("Shipment Added Successfully.\n");


            ////h. Print all shipments using PrintAllShipments().
            //center.PrintAllShipments();

            //// Call DeliveryHelper.PrintShipmentDetails() for each shipment.
            //Console.WriteLine("=============================================");
            //Console.WriteLine("Printing Using DeliveryHelper...\n");

            //DeliveryHelper.PrintShipmentDeails(standard);
            //Console.WriteLine("Standard Shipment Printed Successfully.\n");

            //DeliveryHelper.PrintShipmentDeails(express);
            //Console.WriteLine("Express Shipment Printed Successfully.\n");

            //DeliveryHelper.PrintShipmentDeails(international);
            //Console.WriteLine("International Shipment Printed Successfully.");

            //// j. Demonstrate both versions of UpdateWeight().

            //Console.WriteLine("=============================================");
            //Console.WriteLine("Updating Weight...\n");

            //Console.WriteLine($"Original Weight : {standard.Weight} KG\n");

            //Console.Write("Enter New Weight for Standard Shipment: ");
            //decimal newWeight = decimal.Parse(Console.ReadLine());
            //standard.UpdateWeight(newWeight);
            //Console.WriteLine($"Updated Weight : {standard.Weight} KG\n");

            //Console.Write("Enter Extra Packing Weight: ");
            //decimal extraPacking = decimal.Parse(Console.ReadLine());
            //standard.UpdateWeight(newWeight, extraPacking);
            //Console.WriteLine($"Updated Weight After Packing : {standard.Weight} KG");

            //// Build a Shipment[] holding mixed types and print all of them in a loop.

            //Console.WriteLine("=============================================");
            //Console.WriteLine("Printing Using Shipment[]...\n");

            //Shipment[] shipmentsArray = new Shipment[] { standard, express, international };

            //foreach (var shipment in shipmentsArray)
            //{
            //    if (shipment is StandardShipment)
            //        Console.WriteLine("Standard Shipment...\n");
            //    else if (shipment is ExpressShipment)
            //        Console.WriteLine("Express Shipment...\n");
            //    else if (shipment is InternationalShipment)
            //        Console.WriteLine("International Shipment...\n");
            //}

            //Console.WriteLine("=============================================");
            #endregion




            #region Part 01 : Theoretical Questions /  Question 1 (Abstraction) (OOP4)

            //a) What is Abstraction in Object-Oriented Programming?

            // Abstraction is the process of hiding unnecessary implemention details and exposing only the essential features and behavior of an object.

            //b) Why is abstraction considered one of the four pillars of OOP?

            // Abstraction is one of the four pillars of OOP beacuse it resuces complexity by hiding unnecessary implemention detailsand exposing only essential functionality. This makes software easier to understand, use, maintain, and extend.



            #endregion
            #region Part 01 : Theoretical Questions /  Question 2 (Abstraction) (OOP4)

            //a) What is the difference between an Abstract Class and an Interface?

            //An abstract class is a base class that can contain fields, properties, constructors, implemented methods, and abstract methods. A class can inherit from only one abstract class.

            // An interface defines a contract that specifies what a class must implement. A class can implement multiple interfaces. Interfaces are mainly used to define common behavior without requiring class inheritance.


            // b) When would you choose an Interface instead of an Abstract Class?

            // i would choose an interface when i want to define a cntract or commaon behavior that can be implemented by unrelated classes, especially when a class needs to implement multiple behaviors.

            // c) Can a class inherit from multiple abstract classes? Can it implement multiple interfaces?
            //No, a class cannot inherit from multiple abstract classes because C# does not support multiple class inheritance. However, a class can implement multiple interfaces.

            #endregion


            #region Part 02 : Practical Questions (Abstraction) (OOP4)

            DeliveryCenter center = new DeliveryCenter();
            Console.Write("Enter Center Name: ");
            center.centerName = Console.ReadLine();

            //a. Create one StandardShipment.

            Console.WriteLine("\n--- Enter Standard Shipment Data ---");
            Console.Write("Tracking Code: ");
            string stdCode = Console.ReadLine();
            Console.Write("Description: ");
            string stdDesc = Console.ReadLine();
            Console.Write("Weight: ");
            decimal stdWeight = decimal.Parse(Console.ReadLine());
            Console.Write("Delivery Fee: ");
            decimal stdFee = decimal.Parse(Console.ReadLine());

            Console.Write("City: ");
            string stdCity = Console.ReadLine();
            Console.Write("Street: ");
            string stdStreet = Console.ReadLine();
            Console.Write("Building Number: ");
            int stdBuilding = int.Parse(Console.ReadLine());

            DeliveryAddress stdAddress = new DeliveryAddress { City = stdCity, Street = stdStreet, BuildingNumber = stdBuilding };
            StandardShipment standard = new StandardShipment(stdCode, stdDesc, stdWeight, stdFee, stdAddress);


            //b. Create one ExpressShipment.

            Console.WriteLine("\n--- Enter Express Shipment Data ---");
            Console.Write("Tracking Code: ");
            string expCode = Console.ReadLine();
            Console.Write("Description: ");
            string expDesc = Console.ReadLine();
            Console.Write("Weight: ");
            decimal expWeight = decimal.Parse(Console.ReadLine());
            Console.Write("Delivery Fee: ");
            decimal expFee = decimal.Parse(Console.ReadLine());
            Console.Write("Extra Fee: ");
            decimal expExtraFee = decimal.Parse(Console.ReadLine());

            DeliveryAddress expAddress = new DeliveryAddress { City = stdCity, Street = stdStreet, BuildingNumber = stdBuilding };
            ExpressShipment express = new ExpressShipment(expCode, expDesc, expWeight, expFee, expAddress, expExtraFee);

            //c. Create one InternationalShipment.
            Console.WriteLine("\n--- c. Enter International Shipment Data ---");
            Console.Write("Tracking Code: ");
            string intCode = Console.ReadLine();
            Console.Write("Description: ");
            string intDesc = Console.ReadLine();
            Console.Write("Weight: ");
            decimal intWeight = decimal.Parse(Console.ReadLine());
            Console.Write("Delivery Fee: ");
            decimal intFee = decimal.Parse(Console.ReadLine());
            Console.Write("Destination Country: ");
            string intCountry = Console.ReadLine();
            Console.Write("Customs Fee: ");
            decimal intCustomsFee = decimal.Parse(Console.ReadLine());

            DeliveryAddress intAddress = new DeliveryAddress { City = stdCity, Street = stdStreet, BuildingNumber = stdBuilding };
            InternationalShipment international = new InternationalShipment(intCode, intDesc, intWeight, intFee, intAddress, intCountry, intCustomsFee);


            // d. Add all shipments to the DeliveryCenter.
            center.AddShipment(standard);
            center.AddShipment(express);
            center.AddShipment(international);
            Console.WriteLine("\nAll Shipments Added Successfully.\n");

            //e. Print all shipment details.

            center.PrintAllShipments();
            Console.WriteLine();

            // f & h. Store in ITrackable[] array and print tracking statuses.
            Console.WriteLine("Tracking Status\n");

            ITrackable[] trackableArray = { standard, express, international };
            foreach (var item in trackableArray)
            {
                DeliveryReport.PrintShipment(item);
                Console.WriteLine();
            }
            Console.WriteLine("=============================================\n");

            // g & i. Store in IInsurable[] array and print insurance values.
            Console.WriteLine("Insurance\n");

            IInsurable[] insurableArray = new IInsurable[] { standard, express, international };

            Console.Write("Standard Shipment Insurance : ");
            DeliveryReport.PrintInsurance(insurableArray[0]);
            Console.WriteLine();

            Console.Write("Express Shipment Insurance : ");
            DeliveryReport.PrintInsurance(insurableArray[1]);
            Console.WriteLine();

            Console.Write("International Shipment Insurance : ");
            DeliveryReport.PrintInsurance(insurableArray[2]);
            Console.WriteLine();

            Console.WriteLine("=============================================\n");

            Console.WriteLine("Interface Polymorphism Demonstrated Successfully.");
            #endregion
        }




    }
}
