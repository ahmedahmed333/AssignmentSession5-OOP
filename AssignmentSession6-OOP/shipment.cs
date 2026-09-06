using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentSession6_OOP
{
    public abstract class Shipment
    {
        private string trackingCode;
        private string description;
        private decimal weight;
        private decimal deliveryFee;

        public static int TotalShipmentsCreated;

        // Constructors
        public Shipment(string trackingCode)
        {
            TrackingCode = trackingCode;
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
            Destination = new DeliveryAddress("c", "das", 21);
            TotalShipmentsCreated++;
        }
        public Shipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
        {
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;
            TotalShipmentsCreated++;
        }
        static Shipment()
        {
            TotalShipmentsCreated = 0;
            Console.WriteLine("Shipment System Initialized");
        }
        //  add two versions of the weight-update method
        public void UpdateWeight(decimal newWeight)
        {
            Weight = newWeight;
        }
        public void UpdateWeight(decimal newWeight, decimal extraPackingWeight)
        {
            Weight = newWeight + extraPackingWeight;
        }
        // proporties
        public string TrackingCode
        {

            get
            {

                return trackingCode;
            }


            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    trackingCode = value;
                }
            }
        }
        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    description = value;
                }
            }
        }


        public decimal Weight
        {
            get { return weight; }

            set
            {
                if (value > 0)
                {
                    weight = value;
                }

            }
        }
        public decimal DeliveryFee
        {

            get { return deliveryFee; }
            private set
            {
                if (value > 0)
                {
                    deliveryFee = value;

                }

            }
        }
        public DeliveryAddress Destination { get; set; }

        public string TrackingStatus { get; set; }
        public abstract decimal EstimatedCost { get; }

        // methods
        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                DeliveryFee = newFee;
            }
        }
        public abstract void PrintShipment();


        public static int GetTotalShipmentsCreated()
        {
            return TotalShipmentsCreated;
        }

        public Shipment CopyShipment()
        {
            return ShallowCopy();
        }

        public Shipment ShallowCopy()
        {
            return (Shipment)MemberwiseClone();
        }
        public Shipment DeepCopy()
        {
            Shipment copy = (Shipment)MemberwiseClone();

            copy.Destination = new DeliveryAddress(Destination.City, Destination.Street, Destination.BuildingNumber);

            return copy;
        }
    }

}
