/* Write methods that calculate the surface of a triangle by given: Side and an altitude to it;
   Three sides; Two sides and an angle between them. Use System.Math. */

using System;

class TriangleSurface
{
    static double TriangleSurfaceByTwoSidesAndAngle(double sideA, double sideC, double angleACB)
    {
        double surface = Convert.ToDouble((sideA * sideC * Math.Sin(angleACB)) / 2);
        return surface;
    }

    static double TriangleSurfaceByThreeSides(double sideA, double sideB, double sideC)
    {
        double perimHalf = (sideA + sideB + sideC) / 2;
        double surface = Convert.ToDouble(Math.Sqrt(perimHalf * (perimHalf - sideA) * (perimHalf - sideB) * (perimHalf - sideC)));
        return surface;
    }

    static double TriangleSurfaceBySideAndAltitude(double side, double altitude)
    {
        double surface = (side * altitude) / 2;
        return surface;
    }

    static void Main()
    {
        double a = 3;
        double b = 5;
        double c = 4;
        double ha = 4;
        double angleACB = Convert.ToDouble((Math.PI * 90) / 180);

        Console.WriteLine("The surface of the triangle, calculated by given\n side and altiude to it, is: {0} cm", TriangleSurfaceBySideAndAltitude(a, ha));
        Console.WriteLine("The surface of the triangle, calculated by given\n three sides, is: {0} cm", TriangleSurfaceByThreeSides(a, b, c));
        Console.WriteLine("The surface of the triangle, calculated by given\n two sides and angle between them, is: {0} cm", TriangleSurfaceByTwoSidesAndAngle(a, c, angleACB));
    }
}
