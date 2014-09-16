using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder.Parts
{
    class Chassis
    {
        private int weight;
        private String style;
        private String materialType;
        private String brand;

        public Chassis(int weight, String style, String brand, String materialType = "steel")
        {
            this.weight = weight;
            this.style = style;
            this.materialType = materialType;
            this.brand = brand;
        }

        public string ToString()
        {
            return "Chassis: " + brand + ", Material Type: " + materialType + ", Style: " + style + ", Weight: " + weight + "lbs.";
        }
    }
}
