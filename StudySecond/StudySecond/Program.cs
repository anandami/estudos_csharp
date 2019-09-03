using System;
using System.Globalization;

namespace StudySecond {
    class Program {
        static void Main (string[] args) {
            Triangle X = new Triangle();
            Console.WriteLine("Enter with the size of the triangle X: ");
            X.SideA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            X.SideB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            X.SideC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = X.Area();
            Console.WriteLine(areaX);




        }
    }
}
