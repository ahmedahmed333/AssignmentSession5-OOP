using AssignmentSession6_OOP.shipments;
using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentSession6_OOP
{
    internal class PriorityInternationalShipment : InternationalShipment
    {
        public PriorityInternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, string destinationCountry, decimal customsFee) : base(trackingCode, description, weight, deliveryFee, destination, destinationCountry, customsFee)
        {
        }
        public sealed override void GenerateCustomsReport()
        {
            Console.WriteLine($"Priority Customs Report for {DestinationCountry}");
            Console.WriteLine($"Customs Fee: {CustomsFee} EGP");
        }
    }
}
