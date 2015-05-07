using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuizApp.Models
{
    public class Questianneire
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public virtual Unit Unit { get; set; }
    }
}