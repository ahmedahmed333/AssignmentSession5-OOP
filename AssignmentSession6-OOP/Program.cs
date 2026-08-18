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
            DeliveryAddress address1 = new DeliveryAddress("fysel", "hassan mohamed", 55);
            string fullAddress = address1.GetFullAddress();
            Console.WriteLine(fullAddress); // 55-hassan mohamed-fysel
            DeliveryAddress address2 = address1;
            address1.City = "cairo";
            Console.WriteLine(address1.GetFullAddress()); // 55-hassan mohamed-cairo
            Console.WriteLine(address2.GetFullAddress()); // 55-hassan mohamed-fysel
            Console.WriteLine("=================");

            // a. Create a DeliveryCenter
            DeliveryCenter center = new DeliveryCenter();

            // b & c. Read data for 3 shipments and add them to DeliveryCenter
            for (int i = 1; i <= 3; i++)
            {

                Console.WriteLine($"Enter Shipment {i} Data");
                Console.Write("Tracking Code: ");
                string trackingCode = Console.ReadLine();

                Console.Write("Description: ");
                string description = Console.ReadLine();

                Console.Write("Weight: ");
                double weight = double.Parse(Console.ReadLine());

                Console.Write("Delivery Fee: ");
                decimal deliveryFee = decimal.Parse(Console.ReadLine());

                Console.Write("City: ");
                string city = Console.ReadLine();

                Console.Write("Street: ");
                string street = Console.ReadLine();

                Console.Write("Building Number: ");
                int buildingNumber = int.Parse(Console.ReadLine());

                // Create DeliveryAddress and Shipment objects
                DeliveryAddress address = new DeliveryAddress(street, city, buildingNumber);
                Shipment shipment = new Shipment(trackingCode, description, weight, deliveryFee, address);
                // Add to center
                if (center.AddShipment(shipment))
                {
                    Console.WriteLine("\nShipment added successfully.\n");
                }
            }
                // d. Print the three shipments using the integer indexer
                Console.WriteLine("--- All Shipments");
                for (int n = 0; n < 3; n++)
                {
                    // Using integer indexer center[i]

                    Shipment s = center[n];

                    // Print information
                    Console.WriteLine($"Tracking Code: {s.TrackingCode}");
                    Console.WriteLine($"Description: {s.Description}");
                    Console.WriteLine($"Weight: {s.Weight} KG");
                    Console.WriteLine($"Delivery Fee: {s.DeliveryFee} EGP");
                    Console.WriteLine($"Destination: {s.Destination.GetFullAddress()}");
                    Console.WriteLine($"Estimated Cost: {s.EstimatedCost} EGP\n");
                }

                // e & f & g. Search for shipment using the string indexer
                Console.Write("Enter a tracking code to search: ");

                string searchCode = Console.ReadLine();

                Shipment searchedShipment = center[searchCode];

                if (!string.IsNullOrEmpty(searchedShipment.TrackingCode))
                {
                    Console.WriteLine($"Shipment found: {searchedShipment.TrackingCode} - {searchedShipment.Description}\n");
                }
                else
                {
                    Console.WriteLine("Shipment not found.\n");
                }

                // h. Demonstrate DeliveryAddress struct copy behavior (Value Type Concept)
                Console.WriteLine("--- Struct Copy Test ---");
                DeliveryAddress originalAddress = new DeliveryAddress("Tahrir Street", "Cairo", 15);
                DeliveryAddress copiedAddress = originalAddress;


                copiedAddress.Street = "Makram Ebeid Street";
                copiedAddress.BuildingNumber = 20;

                Console.WriteLine($"Original Address: {originalAddress.GetFullAddress()}");
                Console.WriteLine($"Copied Address: {copiedAddress.GetFullAddress()}");
            }

            #endregion

        
    }
}
