namespace TMSLesson8
{
    public class Accountant : ITitle
    {
        public string Title { get; set; } = "Бухгалтер";

        public void ShowTitle()
        {
            Console.WriteLine($"Название должности: {Title}");
        }
    }
}
