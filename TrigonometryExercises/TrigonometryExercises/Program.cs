using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrigonometryExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DegreeConversion(5));
            Console.WriteLine(RadianConversion(90));
            Console.WriteLine(AngleCalculation(8,6,9));
            Console.WriteLine(Math.Acos(.5));
            Console.ReadLine();
        }

        static double DegreeConversion(double radian)
        {
            double result = (radian / Math.PI) * 180;
            return result;
        }
        static double RadianConversion(double degree)
        {
            double result = (degree / 180) * Math.PI;
            return result;
        }
        static double AngleCalculation(float a, float b, float c)
        {
            double results = Math.Acos(((b * b) + (c * c) - (a * a)) / (2 * b * c));
            results = DegreeConversion(results);
            return results;
        }
    }
}
