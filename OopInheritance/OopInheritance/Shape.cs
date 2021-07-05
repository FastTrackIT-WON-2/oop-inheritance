namespace OopInheritance
{
    public abstract class Shape
    {
        public Shape(Point[] points)
        {
            this.Points = points ?? new Point[0];
        }

        public Point[] Points { get; }

        public abstract double Area { get; }

        public void Rotate(double angleDegrees)
        {
            foreach(Point p in this.Points)
            {
                p.ApplyRotationTransform(angleDegrees);
            }
        }
    }
}
