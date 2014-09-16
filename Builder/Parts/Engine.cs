using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder.Parts
{
    class Engine
    {
        private int cylinders;
        private int weight;
        private String brand;

        public Engine(int cylinders, int weight, String brand)
        {
            this.cylinders = cylinders;
            this.weight = weight;
            this.brand = brand;
        }

        public string ToString()
        {
            return "Engine: " + brand + ", Cylinders: " + cylinders + ", Weight: " + weight + "lbs.";
        }
    }
}
