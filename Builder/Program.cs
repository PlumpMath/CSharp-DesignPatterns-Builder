using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Builder.Builders;

namespace Builder
{
    class Program
    {
        static IBuilder builder;

        static void Main(string[] args)
        {
            /* testing building a vehicle using the Builder design pattern */

            // creating the director to assemble the vehicle parts
            Director vehicleBuildDirector = new Director();
           
            // creating vehicles using the director's Construct method
            // the Construct method uses Builder methods specified by the type of Builder
            Vehicle OEMVehicle = vehicleBuildDirector.Construct(builder = new OEMPlusBuilder());
            Vehicle ApexVehicle = vehicleBuildDirector.Construct(builder = new ApexManufacturingBuilder());

            // displaying vehicle attributes
            Console.WriteLine(OEMVehicle.ToString());
            Console.WriteLine(ApexVehicle.ToString());

            // view console's output
            Console.Read();
        }
    }
}
