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
        // Constructors
        public Shipment(string trackingCode)
        {
            TrackingCode = trackingCode;
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
            Destination = new DeliveryAddress();
        }
        public Shipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
        {
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;
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
      

    }
}
