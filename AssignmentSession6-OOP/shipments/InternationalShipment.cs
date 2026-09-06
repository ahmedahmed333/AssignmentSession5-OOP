using AssignmentSession6_OOP.interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace AssignmentSession6_OOP.shipments
{

    internal class InternationalShipment : Shipment, ITrackable, IInsurable
    {
        public string destinationCountry;
        public decimal customsFee;
        public InternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, string destinationCountry, decimal customsFee) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            CustomsFee = customsFee;
            DestinationCountry = destinationCountry;

        }


        public string DestinationCountry
        {
            get
            {
                return destinationCountry;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    destinationCountry = value;
                }
            }


        }
        public decimal CustomsFee
        {

            get
            {
                return customsFee;
            }

            set
            {
                if (value >= 0)
                {
                    customsFee = value;
                }
            }

        }


        public override decimal EstimatedCost
        {
            get
            {

                return DeliveryFee + (Weight * 5) + CustomsFee;
            }
        }
        public override void PrintShipment()
        {
            Console.WriteLine("International Shipment\n");
            Console.WriteLine($"Tracking Code      : {TrackingCode}");
            Console.WriteLine($"Description        : {Description}");
            Console.WriteLine($"Weight             : {Weight} KG");
            Console.WriteLine($"Delivery Fee       : {DeliveryFee} EGP");
            Console.WriteLine($"Destination Country: {DestinationCountry}");
            Console.WriteLine($"Customs Fee        : {CustomsFee} EGP");
            Console.WriteLine($"Estimated Cost     : {EstimatedCost} EGP");
        }

        public virtual void GenerateCustomsReport()
        {
            Console.WriteLine($"Customs Report for {DestinationCountry}");
            Console.WriteLine($"Customs Fee: {CustomsFee} EGP");
        }

        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} has been Delivered.";
        }

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.12m;
        }
    }
}
