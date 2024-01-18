using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Е14._2
{
    /// <summary>
    /// Класс точек
    /// </summary>
    class Point
    {
        /// <summary>
        /// Поле x
        /// </summary>
        private double x;
        public double X { get => x; set => x = value; }
        /// <summary>
        /// Поле y
        /// </summary>
        private double y;
        public double Y { get => y; set => y = value; }
        /// <summary>
        /// Количество точек 1 четверти
        /// </summary>
        public static int c_I;
        /// <summary>
        /// Количество точек 2 четверти
        /// </summary>
        public static int c_II;
        /// <summary>
        /// Количество точек 3 четверти
        /// </summary>
        public static int c_III;
        /// <summary>
        /// Количество точек 4 четверти
        /// </summary>
        public static int c_IV;
        /// <summary>
        /// Общее кол-во точек
        /// </summary>
        public static int count;
        /// <summary>
        /// Конструктор без параметра
        /// </summary>
        public Point() { }
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Point(double x,double y)
        {
            this.X = x; this.Y = y;
            count++;
            if (x > 0 && y > 0)
            {
                c_I++;
            }
            else if (x < 0 && y > 0)
            {
                c_II++;
            }
            else if (x < 0 && y < 0)
            {
                c_III++;
            }
            else if (x > 0 && y < 0)
            {
                c_IV++;
            }
        }
        public static void Output()
        {
            WriteLine($"1-я четверть: {c_I};\n2-я четверть: {c_II};\n3-я четверть: {c_III};\n4-я четверть: {c_IV};\nОбщее кол-во: {count}");
        }


    }
}
