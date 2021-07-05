using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopInheritance
{
    public class Rectangle : Shape
    {
        public Rectangle(Point topLeft, int width, int height)
        {
            this.TopLeft = topLeft;
            this.TopRight = new Point(topLeft.X + width, topLeft.Y);
            this.BottomLeft = new Point(topLeft.X, topLeft.Y + height);
            this.BottomRight = new Point(topLeft.X + width, topLeft.Y + height);
        }

        public Point TopLeft { get; }

        public Point TopRight { get; }

        public Point BottomLeft { get; }

        public Point BottomRight { get; }

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
            this.TopLeft.ApplyRotationTransform(angleDegrees);
            this.TopRight.ApplyRotationTransform(angleDegrees);
            this.BottomRight.ApplyRotationTransform(angleDegrees);
            this.BottomLeft.ApplyRotationTransform(angleDegrees);
        }
    }
}
