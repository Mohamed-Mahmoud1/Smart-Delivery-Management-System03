namespace Smart_Delivery_Management_System03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 — Theoretical Questions

            #region Question01
            //a)  What is the difference between Method Overloading and Method Overriding?
            //Answer: Overloading is static polymorphism and means having the same method name but a different signature. Overriding is dynamic polymorphism, which means a method inherited from a parent class has a different implementation in the child class.

            //b)  What is the difference between Static Binding and Dynamic Binding?
            //Answer: Static binding is determined at compile time, such as method overloading, method hiding, and operator overloading. Dynamic binding is determined at runtime by the CLR, such as method overriding, abstract methods, and interfaces.

            #endregion

            #region Question02
            //a)  What is the purpose of the sealed keyword when applied to a class?
            // Answer: To prevent the class from being inherited.

            //b)  What is the difference between a sealed class and a sealed method?
            //Answer: 
            // A sealed class is a class that cannot be inherited by any other class.
            // A sealed method is an overridden method in a derived class that is marked with the 'sealed' keyword to prevent any further overriding in subsequent child classes.

            //c)  Can a sealed method be overridden? Why?
            // Answer: No, because "sealed" means that the method cannot be overridden in child classes.

            #endregion

            #endregion

            #region Part 02 — Practical


            #region 1.Update the Shipment Class

            /*
             EstimatedCost:     Convert to a virtual property so each derived class can calculate its own cost.
             PrintShipment():   Convert to a virtual method. Every child class will override it.
            */

            #endregion

            #region 2.Constructor Chaining

            /*
         Derived Class	    Must chain to

         StandardShipment	base(...) → Shipment

         ExpressShipment	base(...) → Shipment

         InternationalShipment	base(...) → Shipment

            */
            #endregion

            #region  3.Override EstimatedCost

            /*
             Class	                    Formula
            StandardShipment	        uses the inherited calculation, unmodified
            ExpressShipment	            DeliveryFee + (Weight × 5) + ExtraFee
            InternationalShipment	    DeliveryFee + (Weight × 5) + CustomsFee

             */

            #endregion

            #region 4.Override PrintShipment()

            /*
                        Field

            Tracking / Description / Weight / Delivery Fee
            Estimated Cost
            Extra Fee
            Destination Country
             Customs Fee

             */
            #endregion

            #region 5.Class Relationships
            #endregion

            #region 6.Update DeliveryCenter
            /*
             	Keep: the Shipment array, AddShipment(), RemoveShipment(), and both indexers — all reused from Assignment 02.
                Modify PrintAllShipments() to loop through the array and simply call shipment.PrintShipment();
                — no manual type-checking. That single call resolving to a different method per object is dynamic binding.
             */
            #endregion

            #region 7.Create DeliveryHelper
            /*
             A static class with one method: void PrintShipmentDetails(Shipment shipment). It calls shipment.PrintShipment(); 
             — whichever override matches the object's real type runs automatically.
             */
            #endregion

            #region 8.Sealed Class

            /*
             Create CompletedShipment, inheriting from Shipment, and mark the class sealed.
             */
            #endregion

            #region 9.Sealed Method

            /*
            In InternationalShipment, add a virtual GenerateCustomsReport().
            In PriorityInternationalShipment (inherits from InternationalShipment), 
            override it and mark that override sealed.
             */

            #endregion

            #region 10.Main() Checklist
            //Driver driver = new Driver();
            //driver.FullName = "Ahmed Mohamed";
            //DeliveryCenter deliverycenter = new DeliveryCenter();                       
            //deliverycenter.Driver = driver;

            //DeliveryAddress deliveryadders = new DeliveryAddress("Germany","",0);

            //StandardShipment standardshipment = new StandardShipment("SH001", "Laptop",3,80,deliveryadders);

            //ExpressShipment expressshipment = new ExpressShipment("SH002", "Mobile Phone", 2, 60, deliveryadders,30);

            //InternationalShipment internationalshipment = new InternationalShipment("SH003", "Television", 8, 120, deliveryadders, "Germany", 100);

            //deliverycenter.AddShipment(standardshipment);
            //deliverycenter.AddShipment(expressshipment);
            //deliverycenter.AddShipment(internationalshipment);

            //Console.WriteLine("==============================");
            //Console.WriteLine("Delivery Center");
            //Console.WriteLine("===============================");

            //Console.WriteLine($"\nDriver:{driver.FullName}\n");
            //Console.WriteLine("--------------------------------------------------");

            //deliverycenter.PrintAllShipments();

            //Console.WriteLine("===================================================");

            //Console.WriteLine("\nPrinting Using DeliveryHelper...\n");
            //DeliveryHelper.PrintShipmentDetails(standardshipment);
            //DeliveryHelper.PrintShipmentDetails(expressshipment);
            //DeliveryHelper.PrintShipmentDetails(internationalshipment);

            //Console.WriteLine("===================================================");
            //Console.WriteLine("\nUpdating Weight...\n");

            //Console.WriteLine($"Original Weight: {standardshipment.Weight}");

            //standardshipment.UpdateWeight(5);
            //Console.WriteLine($"Updated Weight : {standardshipment.Weight}");

            //standardshipment.UpdateWeight(5,0.5m);
            //Console.WriteLine($"Updated Weight After Packing: {standardshipment.Weight}");

            //Console.WriteLine("===================================================");

            //Console.WriteLine("\nPrinting Using Shipment[]...\n");
            //Shipment[] shipments = new Shipment[3];
            //shipments[0] = standardshipment;
            //shipments[1] = expressshipment;
            //shipments[2] = internationalshipment;

            //foreach (Shipment shipment in shipments)
            //{
            //    shipment.PrintShipment();
            //}

            /*Demonstrate the sealed class and sealed method (comments or code).
             A sealed class is a class that cannot be inherited by any other class.
             A sealed method is an overridden method in a derived class that is marked with the 'sealed' keyword to prevent any further overriding in subsequent child classes.
            */
            #endregion


            #endregion

        }
    }
}
