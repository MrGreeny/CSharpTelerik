using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Points
{
    public static class PathStorage
    {        
        //Writes a path of points to a file
        public static void WritePathToFile(Path p)
        {
            StreamWriter streamWriter = new StreamWriter("path.txt");
            using (streamWriter)
            {
                //For every point in the path
                foreach (Point3D point in p.PointPath)
                {
                    //Invokes the ToFile() method of a point, that returns a string
                    // formated like this: X,Y,Z
                    streamWriter.WriteLine(point.ToFile());
                    //Adds a separator '\n'
                    //streamWriter.Write(';');
                }
            }
        }

        public static Path ReadFromFile()
        {
            //Reads the contents of the file
            StreamReader reader = new StreamReader("path.txt");
            string fileContents = reader.ReadToEnd();
            reader.Close();

            Path p = new Path();
            //Splits the string into an array of strings.
            //Each string represents a point for example "1,5,5.9"
            string[] points = fileContents.Split('\n');
            //Creating an array to keep each coordinate of a point
            string[] point = new string[3];
            //For every point in the array points
            for (int i = 0; i < points.Length; i++)
            {
                //Splits the strings into coordinates and parses ir as double
                point = points[i].Split(',');
                //adds a point to the path
                p.Add(new Point3D( double.Parse(point[0]), double.Parse(point[1]), double.Parse(point[2])));
            }
            //returns the path read from the file
            return p;

        }
    }
}
