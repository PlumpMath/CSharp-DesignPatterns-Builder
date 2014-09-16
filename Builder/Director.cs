using System;
using System.Text;
using Builder.Builders;

namespace Builder
{
    /* 
     * The Director is responsible for assembling a product or object which consists of multiple parts.
     * It works with one or more Builders to "Construct" a product/object
     */
    class Director
    {
        public Vehicle Construct(IBuilder builder)
        {
            return new Vehicle(
                builder.BuildChassis(),
                builder.BuildEngine(),
                builder.BuildWheel()
                );
        }
    }
}
