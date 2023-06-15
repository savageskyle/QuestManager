namespace SavageNasRaph1.Server.Models
{
    public class Quize
    {
        public List<Question> Questions { get; set; }
    }
    public class Question
    {
        public string Text { get; set; }
        public List<string> Answers { get; set; }
    }
}
