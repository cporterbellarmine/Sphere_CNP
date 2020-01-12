/**
 * This class models the Sphere class from the Java language to C#.
 * @author Rob Kelley
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
    class Sphere
    {
        private double diameter;

        /**
	     * Empty-argument constructor to put object
	     * into a consistent state.
	     */
        public Sphere()
        {
            diameter = 2.0;
        }//end constructor

        /**
	     * Constructor accepts value of diameter.
	     * Preferred constructor.
	     */
        public Sphere(double diameter)
        {
            this.SetDiameter(diameter);
        }//end constructor

        /**
	     * Calculates the volume of the sphere.
	     * @return volume
	     */
        public double GetVolume()
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(diameter / 2, 3);
        }//end GetVolume

        /**
	     * Calculates the surface area of the sphere.
	     */
        public double GetSurfaceArea()
        {
            return 4.0 * Math.PI * Math.Pow(diameter / 2, 2);
        }//end GetSurfaceArea

        /**
         * Getter for diameter
         */
        public double GetDiameter()
        {
            return diameter;
        }//end GetDiameter

        /**
         * Setter for diameter. Uses bounds checking
         * to ensure that the value is no less than 2.
         */
        public void SetDiameter(double diameter)
        {
            if(diameter < 2)
            {
                this.diameter = 2;
            }//end if
            else
            {
                this.diameter = diameter;
            }//end else
        }//end SetDiameter

        override
        public String ToString()
        {
            return "Sphere [diameter = " + diameter + "]";
        }//end ToString
    }//end class
}//end namespace
