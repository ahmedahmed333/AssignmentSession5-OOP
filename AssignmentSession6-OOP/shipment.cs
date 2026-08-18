using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentSession6_OOP
{
    public struct Shipment
    {

        // Question 02 (a) : 
        // 1- dirct data (do data hiding) : Fields are marked as public , breaking encapsulation by allowing external code to access and modify internal data directly.
        //2- Lack of Data Validation : There is no control over assigned values.
        //3- Loss of Flexibility : Futrue business rules ot calc cannot be added later without breaking existing code that relises on these fields.

        // Question 02 (b) : 
        //  private fields
        private double weight;
        private decimal deliveryFee;
        // Flexibility with validation (Auto-Property allows future modification without breaking code)
        public string Description { get; set; }
        //Data Validation
        public double Weight
        {
            get { return weight; }

            set
            {
                if (value >= 0)
                {
                    weight = value;
                }
                else
                {
                    Console.WriteLine("Weight cannot be negative");
                }
            }
        }
        public decimal DeliveryFee
        {

            get { return deliveryFee; }
            set
            {
                if (value >= 0)
                {
                    deliveryFee = value;

                }
                else
                {
                    Console.WriteLine("Delivery Fee cannot be negative.");
                }
            }
        }
    }
}
