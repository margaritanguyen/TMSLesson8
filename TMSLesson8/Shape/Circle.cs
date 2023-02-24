namespace TMSLesson8
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public override double GetArea() => Math.PI * Math.Pow(Radius, 2);

        public override double GetPerimeter() => 2 * Math.PI * Radius;
    }
}
