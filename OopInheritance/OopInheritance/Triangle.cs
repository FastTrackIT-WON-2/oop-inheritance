using System;

namespace OopInheritance
{
    public class Triangle : Shape
    {
        public Triangle(Point p1, Point p2, Point p3)
            : base (new[] { p1, p2, p3 })
        {
        }

        public Point P1
        {
            get
            {
                return this.Points[0];
            }
        }

        public Point P2
        {
            get
            {
                return this.Points[1];
            }
        }

        public Point P3
        {
            get
            {
                return this.Points[2];
            }
        }

        public override double Area
        {
            get
            {
                // see: https://www.mathopenref.com/coordtrianglearea.html
                double area = Math.Abs(this.P1.X * (this.P2.Y - this.P3.Y) + 
                                       this.P2.X * (this.P3.Y - this.P1.Y) + 
                                       this.P3.X * (this.P1.Y - this.P2.Y)) / 2;
                return Math.Round(area, 2);
            }
        }
    }
}
