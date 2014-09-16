using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Builder.Parts;

namespace Builder
{
    // IBuilder - defines the interface for all Vehicle Builder classes
    interface IBuilder
    {
        // non-specific build methods that a Builder must implement
        Wheel BuildWheel();
        Chassis BuildChassis();
        Engine BuildEngine();
    }
}
