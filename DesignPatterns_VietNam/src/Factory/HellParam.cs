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
