using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_18._03
{
    //internal class Point2D <T>
    internal class Point2D <T> where T: struct
    {
        public T X { get; set; }
        public T Y { get; set; }
        public Point2D(T x, T y)
        {
            X = x;
            Y = y;
        }

        public Point2D()
        {
            X = default(T);
            Y = default(T);
        }

    }
}
