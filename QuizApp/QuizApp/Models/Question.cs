
namespace QuizApp.Models
{
    public class Question
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }

        public virtual Answer Answer { get; set; }
    }
}