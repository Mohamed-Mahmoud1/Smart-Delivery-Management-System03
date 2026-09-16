using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Delivery_Management_System03
{
    public class PriorityInternationalShipment : InternationalShipment
    {
        public PriorityInternationalShipment(string tackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, string destinationcountry, decimal customsfee) : base(tackingCode, description, weight, deliveryFee, destination, destinationcountry, customsfee)
        {
        }

        public override sealed void GenerateCustomsReport()
        {
            Console.WriteLine("This is from PriorityInternationalShipment Class!");
        }


    }
}
