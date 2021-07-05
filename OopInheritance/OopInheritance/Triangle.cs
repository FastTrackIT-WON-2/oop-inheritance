using System;

namespace OopInheritance
{
    public class Triangle : Shape
    {
        public Triangle(Point p1, Point p2, Point p3)
        {
            this.P1 = p1;
            this.P2 = p2;
            this.P3 = p3;
        }

        public Point P1 { get; }

        public Point P2 { get; }

        public Point P3 { get; }

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

        public override void Rotate(double angleDegrees)
        {
            this.P1.ApplyRotationTransform(angleDegrees);
            this.P2.ApplyRotationTransform(angleDegrees);
            this.P3.ApplyRotationTransform(angleDegrees);
        }
    }
}
