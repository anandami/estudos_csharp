using System;
using System.Collections.Generic;
using System.Text;

namespace StudySecond {
    class Triangle {
        //attributes
        public double SideA;
        public double SideB;
        public double SideC;

        //methods - Triangle's area
        public double Area () {
            double p = (SideA + SideB + SideC) / 2.0;
            double sqrt = Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
            return sqrt;
        }
        
    }
}
