namespace _03.Circles_Intersection
{
    public class Circle
    {
        private Point center;
        private double radius;

        public Circle(Point center, double radius)
        {
            this.center = center;
            this.radius = radius;
        }

        public Point Center
        {
            get
            {
                return this.center;
            }
            private set
            {
                this.center = value;
            }
        }

        public double Radius
        {
            get
            {
                return this.radius;
            }
            private set
            {
                this.radius = value;
            }
        }
    }
}