using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFormulas
{
    class Program
    {
        public static Random rd = new Random();
        static void Main(string[] args)
        {
            float[] P = new float[3] { 1, 2, 3 };
            float[] Q = new float[3] { 5, 6, 7 };
            double[] A = new double[3] { 2, 5, 8 };
            double[] B = new double[4] { 2, 5, 8 , 10};
            double[][] numValue = new double[5][];
            for (int i = 0; i < numValue.Length; i++)
            {
                numValue[i] = new double[2];
                for (int j = 0; j < numValue[i].Length; j++)
                {
                    numValue[i][j] = rd.Next(1,5);
                }
            }
            Console.WriteLine(function1(3f));
            Console.WriteLine(function2(1,2,3));
            Console.WriteLine(function3(1,2,3));
            Console.WriteLine(function4(numValue[0],numValue[1]));
            Console.WriteLine(function5(P, Q));
            Console.WriteLine(function6(A, B));
            Console.WriteLine(function7(1, 2, 3,4,5));
            Console.ReadLine();
        }

        static float function1(float x)
        {
            float result = x * x + 2 * x - 7;
            return result;
        }

        static string function2(float a, float b, float c)
        {
            bool check = false;
            string failure = "Polynomial has no roots";
            float sqrRoot1 = 0;
            float sqrRoot2 = 1;
            for (int i = 0; i - 2 < b * b - 4 * a * c; i++)
            {

                float test = (b * b - 4 * a * c) % (i * i);
                if (test == 0)
                {
                    check = true ;
                    sqrRoot1 = i;
                    sqrRoot2 = -i;
                }
            }
            if (check == false)
            {
                return failure;
            }
            float result1 = (-b + sqrRoot1) / (2 * a);
            float result2 = (-b + sqrRoot2) / (2 * a);
            string success = $"The root of your polynomial is {result1} or {result2}";
            return success;
        }

        static float function3(float s, float e, float t)
        {
            float result = s + (t * (e - s));
            return result;
        }

        static double function4(double[] d1, double[] d2)
        {
            double result = Math.Sqrt(Math.Pow(d2[0] - d1[0], 2) + Math.Pow(d2[1] - d1[1], 2));
            return result;
        }

        static float function5(float[] P, float[] Q)
        {
            float result = 0 ;
            for (int i = 0; i < 3; i++)
            {
                result += (P[i] * Q[i]);
            }
            return result;
        }
        static double function6(double[] P, double[] Q)
        {
            double result = (P[0] * Q[0] + P[1] * Q[1] + P[2] * Q[2] + Q[3]) / Math.Sqrt((P[0] * P[0] + P[1] * P[1] + P[2] * P[2]));
            return result;
        }
        static double function7(int t, float P1, float P2, float P3, float P4)
        {
            double results = Math.Pow(1 - t, 3) * P1 + 3 * Math.Pow(1 - t, 2) * P2 + 3 * (t - 1) * Math.Pow(t, 2) * P3 + Math.Pow(t, 3) * P4;
            return results;
        }
    }
}
