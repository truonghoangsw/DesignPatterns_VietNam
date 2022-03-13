using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    //iner factory
    public class Point
    {
        private double x, y;

        internal Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public Point(double a, double b, CoordinateSystem cs = CoordinateSystem.Cartesian) // hell param
        {
            switch (cs)
            {
                case CoordinateSystem.Polar:
                    x = a * Math.Cos(b);
                    y = a * Math.Sin(b);
                    break;
                default:
                    x = a;
                    y = b;
                    break;
            }
        }
        public class PointFactory
        {
            public static Point NewCartesianPoint(double x, double y)
            {
                return new Point(x, y);
            }
            public static Point NewPolarPoint(double rho, double theta)
            {
                return new Point(rho * Math.Cos(theta), rho * Math.Sin(theta));
            }
        }
    }

    
}
