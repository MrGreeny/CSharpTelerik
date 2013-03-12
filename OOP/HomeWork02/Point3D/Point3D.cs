using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Points
{
    public struct Point3D
    {
        //Static field with the point 0 (Ex 2)
        private static Point3D pointZero = new Point3D(0, 0, 0);

        //Autoimplemented properties (Ex 1)
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        //Static propty, that returns the point 0
        public static Point3D PointZero
        {
            //read only
            get
            {
                return pointZero;
            }
        }
       
        //General purpouse constructor
        public Point3D(double x, double y, double z)
            //Default constructor
            :this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        
        public override string ToString()
        {
            return string.Format("Point coordinates:({0},{1},{2})", this.X, this.Y, this.Z);
        }

        //Creates a string formatted in a read and write to file - friendly way
        public string ToFile()
        {
            return string.Format("{0},{1},{2}", this.X, this.Y, this.Z);
        }
    }
}
