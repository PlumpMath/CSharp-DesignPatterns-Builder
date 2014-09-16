using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder.Parts
{
    class Wheel
    {
        private int height;
        private String rim;
        private String brand;

        public Wheel(int height, String brand, String rim = "stock")
        {
            this.height = height;
            this.rim = rim;
            this.brand = brand;
        }

        public string ToString()
        {
            return "Wheel Type: " + brand + ", Rim Type: " + rim + ", Height: " + height + " in.";
        }
    }
}
