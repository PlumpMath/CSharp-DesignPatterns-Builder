using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Builder.Parts;

namespace Builder.Builders
{
    // defines the particular brand "OEMPlus" - which builds parts a particular way
    class OEMPlusBuilder : IBuilder
    {
        public Wheel BuildWheel()
        {
            return new Wheel(18, "OEMPlus", "giant");
        }

        public Chassis BuildChassis()
        {
            return new Chassis(300, "Streamlined", "OEMPlus", "polycarbonate");
        }

        public Engine BuildEngine()
        {
            return new Engine(8, 568, "OEMPlus");
        }
    }
}
