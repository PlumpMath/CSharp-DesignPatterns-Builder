using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Builder.Parts;

namespace Builder.Builders
{
    // defines the particular brand "Apex Manufacturing" - which builds parts a particular way
    class ApexManufacturingBuilder : IBuilder
    {
        public Wheel BuildWheel()
        {
            return new Wheel(22, "Apex Manufacturing", "stingray");
        }

        public Chassis BuildChassis()
        {
            return new Chassis(505, "Streamlined", "Apex Manufacturing", "polycarbonate");
        }

        public Engine BuildEngine()
        {
            return new Engine(8, 890, "Apex Manufacturing");
        }
    }
}
