namespace TMSLesson8
{
    public class Rectangle : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }

        public override double GetArea() => SideA * SideB;

        public override double GetPerimeter() => 2 * (SideA + SideB);
    }
}
