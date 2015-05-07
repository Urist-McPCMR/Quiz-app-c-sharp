
using System.Collections.Generic;
namespace QuizApp.Models
{
    public class Question
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string CorrectAnswer { get; set; }

        public virtual QuestionAnswer Answer { get; set; }
        public virtual TypeQuestion TypeQuestion { get; set; }
        public virtual ICollection<OptionAnswer> OptionsAnswer { get; set; }

    }
}