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

            #endregion

        }
    }
}
