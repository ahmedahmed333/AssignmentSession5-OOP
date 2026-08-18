namespace AssignmentSession6_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 01 
            DeliveryAddress address1 = new DeliveryAddress();
            address1.City = "Giza";
            DeliveryAddress address2 = address1;
            Console.WriteLine(address1.City);//Giza
            Console.WriteLine(address2.City);//Giza
            address1.City = "cairo";
            Console.WriteLine(address1.City);//cairo
            Console.WriteLine(address2.City);//Giza , because DeliveryAddress is struct (value type)
                                             //, so address2 is an independent copy. 
            Console.WriteLine("===========================");
            Customer customer1 = new Customer();
            customer1.Name = "ahmed";
            Customer customer2 = customer1;
            Console.WriteLine(customer1.Name);//ahmed
            Console.WriteLine(customer2.Name);//ahmed
            customer1.Name = "ali";
            Console.WriteLine(customer1.Name);//ali
            Console.WriteLine(customer2.Name);//ali ,  beacuse Customer is class (reference type) ,
                                              //Modifying the object through one variable will affect the other so customer2 will also change to ali
            #endregion
        }
    }
}
