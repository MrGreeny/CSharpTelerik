using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Points
{
    public class Path
    {
        //Uses a generic list to keep points
        private List<Point3D> pointPath;

        //a read only property
        public List<Point3D> PointPath
        {
            get
            {
                return pointPath;
            }
        }

        //Constructor
        public Path()
        {
            pointPath = new List<Point3D>();
        }

        //Adds an element to the path
        public void Add(Point3D p)
        {
            this.pointPath.Add(p);
        }
    }
}
