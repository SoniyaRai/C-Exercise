

namespace ApplicationDevelop_Assignment
{
    public class Shape
    {
        public virtual int CalculateArea()
        {
            return 0;
        }
    }

    public class Circle : Shape
    {
        public int radius;

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public override int CalculateArea()
        {
            var area = (int)(3.14 * radius * radius);
            Console.WriteLine(area);
            return area;
        }
    }
}
