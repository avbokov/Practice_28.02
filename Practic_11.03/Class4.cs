using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_11._03
{
    internal class Point1
    {
        public int X { get; set; }
        public int Y { get; set; }

        public static bool operator true(Point1 p)
        {
            return p.X != 0 || p.Y != 0 ? true : false;
        }
        public static bool operator false(Point1 p)
        {
            return p.X == 0 || p.Y == 0 ? true : false;
        }
        public static Point1 operator |(Point1 p1, Point1 p2)
        {
            if ((p1.X != 0 || p1.Y != 0) || (p2.X != 0 || p2.Y != 0))
                return p2;
            return new Point1();
        }
        public static Point1 operator &(Point1 p1, Point1 p2)
        {
            if ((p1.X != 0 && p1.Y != 0) && (p2.X != 0 && p2.Y != 0))
                return p2;
            return new Point1();
        }
        public override string ToString()
        {
            return $"Point1: X {X}, Y = {Y}";
        }

    }
}
