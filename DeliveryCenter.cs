using System;
using System.Collections.Generic;
using System.Text;

namespace OOP03
{
    internal class DeliveryCenter
    {
        private Shipment[] shipments =
            new Shipment[20];

        public string CenterName
        {
            get;
            set;
        }

        public Driver Driver
        {
            get;
            set;
        }

        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 &&
                    index < shipments.Length)
                {
                    return shipments[index];
                }

                return null;
            }

            set
            {
                if (index >= 0 &&
                    index < shipments.Length)
                {
                    shipments[index] = value;
                }
            }
        }

        public Shipment this[string trackingCode]
        {
            get
            {
                for (int i = 0;
                     i < shipments.Length;
                     i++)
                {
                    if (shipments[i] != null &&
                        shipments[i].TrackingCode ==
                        trackingCode)
                    {
                        return shipments[i];
                    }
                }

                return null;
            }
        }

        public bool AddShipment(
            Shipment shipment)
        {
            if (shipment == null)
            {
                return false;
            }

            for (int i = 0;
                 i < shipments.Length;
                 i++)
            {
                if (shipments[i] == null)
                {
                    shipments[i] = shipment;
                    return true;
                }
            }

            return false;
        }

        public bool RemoveShipment(
            string trackingCode)
        {
            for (int i = 0;
                 i < shipments.Length;
                 i++)
            {
                if (shipments[i] != null &&
                    shipments[i].TrackingCode ==
                    trackingCode)
                {
                    shipments[i] = null;
                    return true;
                }
            }

            return false;
        }

        public void PrintAllShipments()
        {
            for (int i = 0;
                 i < shipments.Length;
                 i++)
            {
                if (shipments[i] != null)
                {
                    shipments[i].PrintShipment();

                    Console.WriteLine(
                        "------------------------------------------");
                }
            }
        }
    }
}
