using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    public class Point3D
    {
        public double x, y, z;

        public Point3D()
        {
            x = 0;
            y = 0;
            z = 0;
        }
        public Point3D(double a, double _length, double c)
        {
            x = a;
            y = _length;
            z = c;
        }
        public Point3D(Point3D A)
        {
            x = A.x;
            y = A.y;
            z = A.z;
        }
        ~Point3D()
        {
        }
    }
}
