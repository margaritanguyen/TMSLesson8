namespace TMSLesson8
{
    public class Worker : ITitle
    {
        public string Title { get; set; } = "Рабочий";

        public void ShowTitle()
        {
            Console.WriteLine($"Название должности: {Title}");
        }
    }
}
