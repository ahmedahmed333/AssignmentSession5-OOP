using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentSession6_OOP
{
    public struct DeliveryCenter()
    {
        private Shipment[] shipments = new Shipment[10];
        private int count = 0;

        public bool AddShipment(Shipment shipment)
        {
            if (count >= 10)
            {
                return false;
            }
            shipments[count] = shipment;
            count++;
            return true;
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
