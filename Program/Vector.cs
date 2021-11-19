using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Vector
    {
        public double x;
        public double y;
        public double z;

        public Vector(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public void VectorInfo(Vector a)
        {
            Console.WriteLine("x: " + a.x + ", y: " + a.y + ", z: " + a.z);
        }
        public double Length(Vector a)
        {
            return Math.Sqrt((a.x * a.x) + (a.y * a.y) + (a.z * a.z));
        }
        public double ScalarMultiple(Vector a, Vector b)
        {
            return (a.x * b.x) + (a.y * b.y) + (a.z * b.z);
        }
        public Vector VectorMultiple(Vector a, Vector b)
        {
            Vector vector = new Vector((a.y * b.z - a.z * b.y), (a.z * b.x - a.x * b.z), (a.x * b.y - a.y * b.x));
            return vector;
        }
        public Vector VectorDifference(Vector a, Vector b)
        {
            Vector vector = new Vector((a.x - b.x), (a.y - b.y), (a.z - b.z));
            return vector;
        }
        public Vector VectorSum(Vector a, Vector b)
        {
            Vector vector = new Vector((a.x + b.x), (a.y + b.y), (a.z + b.z));
            return vector;
        }

    }
}
