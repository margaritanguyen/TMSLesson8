namespace TMSLesson8
{
    public class Director : ITitle
    {
        public string Title { get; set; } = "Директор";

        public void ShowTitle()
        {
            Console.WriteLine($"Название должности: {Title}");
        }
    }
}
