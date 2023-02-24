namespace TMSLesson8
{
    public class Triangle : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public override double GetArea()
        {
            double p = GetPerimeter() / 2;

            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        public override double GetPerimeter() => SideA + SideB + SideC;
    }
}
