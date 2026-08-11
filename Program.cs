namespace OOP03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 01
            ///a)  What is the difference between Method Overloading and Method Overriding?
            // overloading is when you have multiple methods in the same class with the same name but different parameters (different type or number of parameters).
            // Overriding is when a derived class provides a specific implementation of a method that is already defined in its base class.
            // Overriding requires inheritance and the use of the 'virtual' and 'override' keywords.
            /// b)  What is the difference between Static Binding and Dynamic Binding?
            // Static binding (also known as early binding) occurs at compile time, where the method to be invoked is determined based on the reference type.
            // Dynamic binding (also known as late binding) occurs at runtime, where the method to be invoked is determined based on the actual object type.
            #endregion

            #region Question 02
            /// a)  What is the purpose of the sealed keyword when applied to a class?
            // The sealed keyword is used to prevent a class from being inherited. When a class is marked as sealed, it cannot serve as a base class for any other class.
            // This is useful when you want to restrict the inheritance hierarchy and ensure that the class's implementation remains unchanged.
            /// b)  What is the difference between a sealed class and a sealed method?
            // A sealed class cannot be inherited, meaning no other class can derive from it. A sealed method, on the other hand, is a method that cannot be overridden in any derived class.
            // It can only be used in the class where it is defined or in classes that inherit from it, but those classes cannot provide their own implementation of that method.
            /// c)  Can a sealed method be overridden? Why?
            // No, a sealed method cannot be overridden. The purpose of sealing a method is to prevent any further overriding in derived classes. When a method is marked as sealed,
            // it indicates that the implementation provided in the base class is final and should not be changed by any subclass.
            // This ensures that the behavior of the method remains consistent and cannot be altered by subclasses.
            #endregion

            #region Question 03
            // Part 02 — Practical
            // ==========================================
            // Create Driver
            // ==========================================

            Driver driver =
                new Driver(
                    1,
                    "Ahmed Mohamed",
                    "01012345678");


            // ==========================================
            // Create Delivery Center
            // ==========================================

            DeliveryCenter center =
                new DeliveryCenter();

            center.CenterName =
                "Smart Delivery Center";

            center.Driver = driver;


            // ==========================================
            // Create Address 1
            // ==========================================

            DeliveryAddress address1 =
                new DeliveryAddress(
                    "Cairo",
                    "Tahrir Street",
                    15);


            // ==========================================
            // Standard Shipment
            // ==========================================

            StandardShipment standard =
                new StandardShipment(
                    "SH001",
                    "Laptop",
                    3,
                    80,
                    address1);


            // ==========================================
            // Create Address 2
            // ==========================================

            DeliveryAddress address2 =
                new DeliveryAddress(
                    "Giza",
                    "Pyramids Street",
                    20);


            // ==========================================
            // Express Shipment
            // ==========================================

            ExpressShipment express =
                new ExpressShipment(
                    "SH002",
                    "Mobile Phone",
                    2,
                    60,
                    address2,
                    30);


            // ==========================================
            // Create Address 3
            // ==========================================

            DeliveryAddress address3 =
                new DeliveryAddress(
                    "Cairo",
                    "Nasr City",
                    10);


            // ==========================================
            // International Shipment
            // ==========================================

            InternationalShipment international =
                new InternationalShipment(
                    "SH003",
                    "Television",
                    8,
                    120,
                    address3,
                    "Germany",
                    100);


            // ==========================================
            // Add Shipments
            // ==========================================

            center.AddShipment(standard);
            center.AddShipment(express);
            center.AddShipment(international);


            // ==========================================
            // Delivery Center
            // ==========================================

            Console.WriteLine(
                "==========================================");

            Console.WriteLine(
                "Delivery Center");

            Console.WriteLine(
                "==========================================");

            Console.WriteLine(
                $"Driver : {center.Driver.FullName}");

            Console.WriteLine(
                "------------------------------------------");


            // ==========================================
            // Print All Shipments
            // ==========================================

            center.PrintAllShipments();


            // ==========================================
            // DeliveryHelper
            // ==========================================

            Console.WriteLine();

            Console.WriteLine(
                "==========================================");

            Console.WriteLine(
                "Printing Using DeliveryHelper...");

            Console.WriteLine(
                "==========================================");


            DeliveryHelper.PrintShipmentDetails(
                standard);

            Console.WriteLine(
                "Standard Shipment Printed Successfully.");


            DeliveryHelper.PrintShipmentDetails(
                express);

            Console.WriteLine(
                "Express Shipment Printed Successfully.");


            DeliveryHelper.PrintShipmentDetails(
                international);

            Console.WriteLine(
                "International Shipment Printed Successfully.");


            // ==========================================
            // Method Overloading
            // ==========================================

            Console.WriteLine();

            Console.WriteLine(
                "==========================================");

            Console.WriteLine(
                "Updating Weight...");

            Console.WriteLine(
                "==========================================");

            Console.WriteLine(
                $"Original Weight : {standard.Weight} KG");


            // First version
            standard.UpdateWeight(5);

            Console.WriteLine(
                $"Updated Weight : {standard.Weight} KG");


            // Second version
            standard.UpdateWeight(
                5,
                0.5m);

            Console.WriteLine(
                $"Updated Weight After Packing : " +
                $"{standard.Weight} KG");


            // ==========================================
            // Shipment Array - Polymorphism
            // ==========================================

            Console.WriteLine();

            Console.WriteLine(
                "==========================================");

            Console.WriteLine(
                "Printing Using Shipment[]...");

            Console.WriteLine(
                "==========================================");


            Shipment[] shipments =
            {
                standard,
                express,
                international
            };


            foreach (Shipment shipment in shipments)
            {
                shipment.PrintShipment();

                Console.WriteLine(
                    "------------------------------------------");
            }


            // ==========================================
            // Sealed Method
            // ==========================================

            Console.WriteLine();

            Console.WriteLine(
                "==========================================");

            Console.WriteLine(
                "Sealed Method Demonstration");

            Console.WriteLine(
                "==========================================");


            PriorityInternationalShipment priority =
                new PriorityInternationalShipment(
                    "SH004",
                    "Documents",
                    2,
                    100,
                    address3,
                    "France",
                    50);

            priority.GenerateCustomsReport();


            // ==========================================
            // Sealed Class
            // ==========================================

            CompletedShipment completed =
                new CompletedShipment(
                    "SH005",
                    "Book",
                    1,
                    50,
                    address1);

            completed.PrintShipment();


            // The following code would NOT compile:
            //
            // class Test : CompletedShipment
            // {
            // }
            //
            // Because CompletedShipment is sealed.


            // The following would also NOT compile:
            //
            // public override void GenerateCustomsReport()
            // {
            // }
            //
            // inside a class derived from
            // PriorityInternationalShipment,
            // because the method is sealed.


            Console.WriteLine();

            Console.WriteLine(
                "==========================================");

            Console.WriteLine(
                "Program Finished");

            Console.WriteLine(
                "==========================================");
        }

            #endregion
    
    }
}
