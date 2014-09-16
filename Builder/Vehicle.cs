using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Builder.Parts;


namespace Builder
{
    // Vehicle - The product that will be constructed by the Director. Consists of multiple parts
    class Vehicle
    {
        private Chassis chassis;
        private Engine engine;
        private Wheel wheelType;

        public Vehicle(Chassis chassis, Engine engine, Wheel wheelType)
        {
            this.chassis = chassis;
            this.engine = engine;
            this.wheelType = wheelType;
        }

        public String ToString()
        {
            return "Vehicle Specifications:\n\n" +
                   chassis.ToString() + "\n" +
                   engine.ToString() + "\n" +
                   wheelType.ToString() + "\n\n";
        }
    }
}
