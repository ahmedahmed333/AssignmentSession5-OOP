using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentSession6_OOP
{
    public class DeliveryCenter
    {
        private Shipment[] shipments = new Shipment[20];
        public Driver? Driver { get; set; }
        public string centerName;

        private int count = 0;

        public bool AddShipment(Shipment shipment)
        {
            if (count >= 20)
            {
                return false;
            }
            shipments[count] = shipment;
            count++;
            return true;
        }
        public bool RemoveShipment(string trackingCode)
        {
            for (int i = 0; i < count; i++)
            {
                if (shipments[i].TrackingCode == trackingCode)
                {
                    for (int j = i; j < count - 1; j++)
                    {
                        shipments[j] = shipments[j + 1];
                    }
                    shipments[count - 1] = null;

                    count--;
                    return true;
                }
            }
            return false;
        }

        public void PrintAllShipments()
        {
            Console.WriteLine("=============================================");
            Console.WriteLine($"Delivery Center : {centerName}");
            Console.WriteLine("=============================================");
            for (int i = 0; i < count; i++)
            {
                shipments[i].PrintShipment();
                if (i < count - 1)
                {
                    Console.WriteLine("---------------------------------------------");
                }
            }
        }
        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < count)
                {
                    return shipments[index];
                }
                return default;
            }
            set
            {
                if (index >= 0 && index < count)
                {
                    shipments[index] = value;
                }
            }
        }
        public Shipment this[string trackingCode]
        {
            get
            {
                for (int i = 0; i < count; i++)
                {
                    if (shipments[i].TrackingCode == trackingCode)
                    {
                        return shipments[i];
                    }
                }
                return default;
            }
        }
    }
}
