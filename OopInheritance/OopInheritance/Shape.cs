using System;

namespace OopInheritance
{
    public abstract class Shape
    {
        public Shape(Point[] points)
        {
            this.Points = points ?? new Point[0];
        }

        public Point[] Points { get; }

        public abstract string Name { get; }

        public abstract double Area { get; }

        public virtual void Rotate(double angleDegrees)
        {
            Console.WriteLine($"Rotating {Name} with {angleDegrees} degrees");

            foreach(Point p in this.Points)
            {
                p.ApplyRotationTransform(angleDegrees);
            }
        }
    }
}
