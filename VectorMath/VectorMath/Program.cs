using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorMath
{

    class Vector2 {
        public float x, y;

        public Vector2(float xValue, float yValue)
        {
            x = xValue;
            y = yValue;
        }
        public float Magnitude()
        {
            return (float)Math.Sqrt(x * x + y * y);
        }

        public float MagnitudeSqr()
        {
            return (x * x + y * y);
        }

        public float Distance(Vector2 other)
        {
            float diffX = x - other.x;
            float diffY = y - other.y;
            return (float)Math.Sqrt(diffX * diffX + diffY * diffY);
        }

        public float DistanceSqr(Vector2 other)
        {
            float diffX = x - other.x;
            float diffY = y - other.y;
            return (diffX * diffX + diffY * diffY);
        }
        public void Normalize()
        {
            float m = Magnitude();
            this.x /= m;
            this.y /= m;
        }
        Vector2 GetPerpendicularRH()
        {
            return { -y, x};
        }
        public float Dot(Vector2 rhs)
        {
            return x * rhs.x + y * rhs.y;
        }
        
    }

    class Vector3
    {
        public float x, y, z;
        public Vector3(float xValue, float yValue, float zValue)
        {
            x = xValue;
            y = yValue;
            z = zValue;
        }
        public float Magnitude()
        {
            return (float)Math.Sqrt(x * x + y * y + z * z);
        }

        public float MagnitudeSqr()
        {
            return (x * x + y * y + z * z);
        }

        public float Distance(Vector3 other)
        {
            float diffX = x - other.x;
            float diffY = y - other.y;
            float diffZ = z - other.z;
            return (float)Math.Sqrt(diffX * diffX + diffY * diffY + diffZ * diffZ);
        }

        public float DistanceSqr(Vector3 other)
        {
            float diffX = x - other.x;
            float diffY = y - other.y;
            float diffZ = z - other.z;
            return (diffX * diffX + diffY * diffY + diffZ * diffZ);
        }
        public void Normalize()
        {
            float m = Magnitude();
            this.x /= m;
            this.y /= m;
            this.z /= m;
        }
        public float Dot(Vector3 rhs)
        {
            return x * rhs.x + y * rhs.y + z * rhs.z;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vector3 num1 = new Vector3(1,1,1);
            Vector2 num2 = new Vector2(3, -2);
            Vector3 num3 = new Vector3(-1, 1, -1);
            Vector3 num4 = new Vector3(.5f, -1f, .25f);
            Vector2 num5 = new Vector2(-2, 5.5f);
            Vector2 num6 = new Vector2(9, -22);
            Vector3 num7 = new Vector3(0, 1, 2);
            Vector3 num8 = new Vector3(9, -2, 7);
            Console.WriteLine($"{num1.Magnitude()} {num2.Magnitude()} {num3.Magnitude()} {num4.Magnitude()} {num5.Distance(num6)} {num7.Distance(num8)}");
            Console.ReadLine();
        }  
    }
}
