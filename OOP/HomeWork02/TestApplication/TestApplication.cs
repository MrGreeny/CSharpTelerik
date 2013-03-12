using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Points;
using Generic;
using Versions;
using System.IO;

namespace TestApplication
{
    class TestApplication
    {
        //Sample enum type to test the [Version] attribute.
        [Version("1.0.1.7")]
        private enum SampleEnum
        {
            Monday,
            Tuesday
        }

        static void Main(string[] args)
        {


            Console.WriteLine("Point3D Test.");
            //Testing the struct Point3D, the static field PointZero and the method 
            //for calculating the distance
            Point3D a = new Point3D(1, 2, 3);
            double dist = CalculateDistance.Calculate(Point3D.PointZero, a);
            Console.WriteLine("The distance between point 0 and the point {0} is {1:F2} units.", a.ToString(), dist);

            //=========================
            //Testing the generic list
            Console.WriteLine("\nGeneric list test.");
            GenericList<int> list = new GenericList<int>(5);

            //Adding some values.
            Console.WriteLine("Adding values...");
            list.Add(5);
            list.Add(8);
            list.Add(7);
            list.Add(99);
            Console.WriteLine(list.ToString());

            //Removing at a given index
            Console.WriteLine("Removing the element at index 4");
            list.Remove(4);
            Console.WriteLine(list.ToString());

            //Accessing an element
            Console.WriteLine("The element with the index 4 is:");
            Console.WriteLine(list[4]);

            ////Inserting element
            Console.WriteLine("Inserting element 888 at position 2");
            list.Insert(888, 2);
            Console.WriteLine(list.ToString());

            //Finding the minimal value
            Console.WriteLine("Minimal value from the list: {0}",list.Min<int>());

            //=========================

            //Testing the generic class Matrix
            Console.WriteLine("\nGeneric matrix test");
            Matrix<int> m1 = new Matrix<int>(1, 3);
            m1[0, 0] = 1;
            m1[0, 1] = 0;
            m1[0, 2] = -6;
            Console.WriteLine("\nMatrix 1");
            m1.PrintMatrix();

            //Testing the true/false operators
            if (m1)
            {
                Console.WriteLine("Matrix 1is not equivalent to zero");
            }
            else
            {
                Console.WriteLine("This is the zero matrix");
            }

            Matrix<int> m2 = new Matrix<int>(3, 2);
            m2[0, 0] = 2;
            m2[0, 1] = 3;
            m2[1, 0] = 5;
            m2[1, 1] = 8;
            m2[2, 0] = 7;
            m2[2, 1] = 9;
            Console.WriteLine("Matrix 2:");
            m2.PrintMatrix();


            ////Testing multiplication
            Console.WriteLine("Matrix1*Matrix2 =");
            Matrix<int> m3 = m1 * m2;
            m3.PrintMatrix();

            //=========================
            Console.WriteLine("\nTesting Versions:");

            Type type = typeof(SampleEnum);
            object[] allAtributes = type.GetCustomAttributes(false);

            foreach (VersionAttribute attr in allAtributes)
            {
                Console.WriteLine("Version: {0}", attr.Version);
            }

            //Path storage test
            Console.WriteLine("\nPath Storage test");
            Point3D c = new Point3D(0, 0, 0);
            Point3D d = new Point3D(0, 1, 8);
            Point3D e = new Point3D(2.5, 0, 6);
            Point3D f = new Point3D(10, 20, 10);
            Point3D g = new Point3D(5, 2, 6);

            //Using Points.Path because System.IO.Path
            Points.Path path = new Points.Path();
            path.Add(c);
            path.Add(d);
            path.Add(e);
            path.Add(f);
            path.Add(g);

            PathStorage.WritePathToFile(path);
            StreamReader reader = new StreamReader("path.txt");
            string fileContents = reader.ReadToEnd();
            Console.WriteLine("path.txt contents:");
            Console.WriteLine(fileContents);
            reader.Close();

            

        }

    }
}
