namespace DataModel.Models
{
    public class Choice
    {
        public int Id { get; set; }
        public string Option { get; set; }
        public bool IsCorrect { get; set; }

        public virtual Question Question { get; set; }
    }
}