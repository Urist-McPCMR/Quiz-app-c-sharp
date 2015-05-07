using QuizApp.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace QuizApp.DAL
{
    public class QuizContext : DbContext
    {
        public QuizContext() : base("QuizContext")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Lecturer> Lecturers { get; set; }
        
        public DbSet<Unit> Units { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Questianneire> Questianneires { get; set; }

        public DbSet<Question> Questions { get; set; }

        public DbSet<OptionAnswer> OptionAnswers { get; set; }

        public DbSet<TypeQuestion> TypeQuestions { get; set; }

        public DbSet<QuestionAnswer> QuestionAnswers { get; set; }
    }
}