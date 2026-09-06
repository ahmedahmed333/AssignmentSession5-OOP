using AssignmentSession6_OOP.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentSession6_OOP.shipments
{
    internal class ExpressShipment : Shipment, ITrackable, IInsurable
    {
        public decimal extraFee;

        public ExpressShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, decimal extraFee) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            ExtraFee = extraFee;
        }
        public decimal ExtraFee
        {
            get
            {
                return extraFee;
            }
            set
            {
                if (value >= 0)
                {
                    extraFee = value;
                }
            }
        }

        public override decimal EstimatedCost
        {
            get
            {

                return DeliveryFee + (Weight * 5) + ExtraFee;
            }
        }

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.08m;
        }

        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is Out for Delivery.";
        }

        public override void PrintShipment()
        {
            Console.WriteLine("Express Shipment\n");
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description   : {Description}");
            Console.WriteLine($"Weight        : {Weight} KG");
            Console.WriteLine($"Delivery Fee  : {DeliveryFee} EGP");
            Console.WriteLine($"Extra Fee     : {ExtraFee} EGP");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }

    }

}
