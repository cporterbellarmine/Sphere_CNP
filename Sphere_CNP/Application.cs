/**
 * This is the application of the class Sphere.
 * @author cporter
 * @version 1/12/2020
 * CS-311 Programming Project 1
 * Spring 2020
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sphere_CNP
{
    class Application
    {
        static void Main(string[] args)
        {

            Sphere s1 = new Sphere();
            Console.WriteLine("Testing my empty constructor:");
            Console.WriteLine();
            Console.WriteLine($"My empty constructor has a diameter value of {s1.GetDiameter()}, a" +
                $" surface area of {Math.Round(s1.GetSurfaceArea(), 2)}, and a volume of {Math.Round(s1.GetVolume(), 2)}.");

            Sphere s2 = new Sphere(1);
            Sphere s3 = new Sphere(5);
            Sphere s4 = new Sphere(20);

            Console.WriteLine();
            Console.WriteLine("Testing my bounds setters for radius:");
            Console.WriteLine();
            Console.WriteLine($"My entered diameter value is 1. The value after bounds checking" +
                $" is {s2.GetDiameter()}, the surface area is {Math.Round(s2.GetSurfaceArea(), 2)}," +
                $" and the volume is {Math.Round(s2.GetVolume(), 2)}.");

            Console.WriteLine();
            Console.WriteLine("Other values:");
            Console.WriteLine();
            Console.WriteLine($"My sphere has a diameter value of {s3.GetDiameter()}," +
                $" a surface area of {Math.Round(s3.GetSurfaceArea(), 2)}, and a volume of {Math.Round(s3.GetVolume(), 2)}.");
            Console.WriteLine($"My sphere has a diameter value of {s4.GetDiameter()}," +
                $" a surface area of {Math.Round(s4.GetSurfaceArea(), 2)}, and a volume of {Math.Round(s4.GetVolume(), 2)}.");
            Console.WriteLine();

        }//end main
    }//end class
}//end namespace
