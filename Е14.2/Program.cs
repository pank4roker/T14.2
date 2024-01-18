using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Е14._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Point[] points = new Point[5]; 
            for(int i = 0; i<points.Length; i++)
            {
                Write("x = ");
                double x = Convert.ToDouble(ReadLine());
                Write("y = ");
                double y = Convert.ToDouble(ReadLine());
                points[i] = new Point(x, y);
            }
            Point.Output();
            ReadKey();
        }
    }
}
