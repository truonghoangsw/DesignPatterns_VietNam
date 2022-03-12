using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public enum CoordinateSystem
    {
        Cartesian,
        Polar
    }

    public class Point
    {
        private double x,y;

        protected Point(double x, double y)
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
    }
    public class Point_optimal
    {
        private double x, y;
        // factory method
        public static Point_optimal NewCartesianPoint(double x, double y)
        {
            return new Point_optimal(x,y);
        }
        public static Point_optimal NewPolarPoint(double rho, double theta)
        {
            return new Point_optimal(rho*Math.Cos(theta), rho* Math.Sin(theta));
        }
        private Point_optimal(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
