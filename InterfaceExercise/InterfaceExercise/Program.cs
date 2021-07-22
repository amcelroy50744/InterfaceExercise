using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            SUV sorent = new SUV();
            sorent.countryOfOrgin = "Korean";
            sorent.doorCount = 4;
            sorent.logo = "Gia";
            Console.WriteLine("The brandnew Kia Sorento has these features:");
            Console.WriteLine($"{sorent.countryOfOrgin}");
            Console.WriteLine($" Door count: {sorent.doorCount}");
            Console.WriteLine($"Logo: {sorent.logo}");

            Truck f150 = new Truck();
            f150.offRoadEnabled = true;
            f150.wheelSize = 22;
            f150.countryOfOrgin = "USA";
            f150.logo = "Ford";
            Console.WriteLine("The brandnew F150 has these features:");
            Console.WriteLine($"Off Road enabled: {f150.offRoadEnabled}");
            Console.WriteLine($"Wheel Size: {f150.wheelSize}");
            Console.WriteLine($"Country of Orgin {f150.countryOfOrgin}");
            Console.WriteLine($"Logo {f150.logo}");

            Car Camery = new Car();
            Camery.sedan = true;
            Camery.logo = "Toyota";
            Camery.doorCount = 4;
            Console.WriteLine("The brand new Camery has these features:");
            Console.WriteLine($"Is is a Sedan{Camery.sedan}");
            Console.WriteLine($"Logo: {Camery.logo}");
            Console.WriteLine($"Door Count: {Camery.doorCount}");


            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: All vehicles have a number of wheels... for now..
                 */
            

            //In ICompany
            
                /*Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 *
                 *
                 * Example: public string Logo { get; set; }
                 */

            //In each of your car, truck, and suv classes

                /*Create 2 members that are specific to each class
                 * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 * 
                 */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
        }
    }
}
