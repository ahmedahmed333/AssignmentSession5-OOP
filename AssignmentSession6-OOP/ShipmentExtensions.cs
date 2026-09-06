using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentSession6_OOP
{
    internal static class ShipmentExtensions
    {

        public static string GetSummary(this Shipment shipment )
        {
            return $"{shipment.TrackingCode} | {shipment.GetType().Name.Replace("Shipment", "")} | {shipment.Weight} KG | {shipment.TrackingStatus}";
        }

        public static bool IsDelivered(this Shipment shipment)
        {
            return shipment.TrackingStatus == "Delivered";
        }
    }
}
