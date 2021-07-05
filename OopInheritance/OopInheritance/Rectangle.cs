using System;

namespace OopInheritance
{
    public class Rectangle : Shape
    {
        public Rectangle(Point topLeft, int width, int height)
            : base(new[]
                   {
                       topLeft,
                       new Point(topLeft.X + width, topLeft.Y),
                       new Point(topLeft.X + width, topLeft.Y + height),
                       new Point(topLeft.X, topLeft.Y + height)
                   })
        {
        }

        public Point TopLeft 
        { 
            get
            {
                return this.Points[0];
            }
        }

        public Point TopRight
        {
            get
            {
                return this.Points[1];
            }
        }

        public Point BottomRight
        {
            get
            {
                return this.Points[2];
            }
        }

        public Point BottomLeft
        {
            get
            {
                return this.Points[3];
            }
        }

        public override string Name { get { return "Rectangle"; } }

        public override double Area
        {
            get
            {
                double x1 = this.TopLeft.X;
                double y1 = this.TopLeft.Y;

                double x2 = this.TopRight.X;
                double y2 = this.TopRight.Y;

                double x3 = this.BottomRight.X;
                double y3 = this.BottomRight.Y;

                double x4 = this.BottomLeft.X;
                double y4 = this.BottomLeft.Y;


                double area = Math.Abs((x1 * y2 - y1 * x2) +
                                       (x2 * y3 - y2 * x3) +
                                       (x3 * y4 - y3 * x4) +
                                       (x4 * y1 - y4 * x1)) / 2;

                return area;
            }
        }

        public override void Rotate(double angleDegrees)
        {
            Console.WriteLine($"Preparing to rotate a {Name} ...");
            base.Rotate(angleDegrees);
            Console.WriteLine($"{Name} was rotated with {angleDegrees} degrees...");
        }


    }
}
