namespace CapitalPlacementAPI.Models.ApplicationForm
{
    public class Questions
    {
        public int Id { get; set; }
        public QuestionType QuestionType { get; set; }
        public string Question { get; set; }
        public List<string> Choices { get; set; }
        public bool OnlyOneAnswerAllowed { get; set; }

    }

    public class QuestionType
    {
        public string Label { get; set; }
        public int Value { get; set; }
    }
}
