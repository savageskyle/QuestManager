namespace SavageNasRaph1.Server.Models
{
    public class Quize
    {
        public string Id { get; set; }
        public List<Question> Questions { get; set; }
        public List<KeyValuePair<string,int>> Marks { get; set; }
    }
    public class Question
    {
        public string Text { get; set; }
        public List<string> Answers { get; set; }
    }
}
