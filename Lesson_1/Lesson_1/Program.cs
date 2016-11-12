using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1
{
    struct Vector
    {

        public double X { get; set; }
        public double Y { get; set; }


        public Vector(double _x, double _y)
        {
            X = _x;
            Y = _y;
        }

        static public Vector operator+(Vector v1, Vector v2)
        {
            Vector v3 = new Vector(v1.X + v2.X, v1.Y + v2.Y);
            return v3;
        }

        static public Vector operator -(Vector v1, Vector v2)
        {
            Vector v3 = new Vector(v1.X - v2.X, v1.Y - v2.Y);
            return v3;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Vector v1;
            //v1 = new Vector(20, 20);
           // Console.Write(v1.X);
            Vector v2 = new Vector(30,30);
            Vector v3 = new Vector(40,40);
            Vector v4 = v2 + v3;
            Vector v5 = v2 - v3;
        }
    }
}
