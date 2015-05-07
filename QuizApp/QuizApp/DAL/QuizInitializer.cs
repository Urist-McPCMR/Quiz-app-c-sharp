using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QuizApp.Models;

namespace QuizApp.DAL
{
    public class QuizInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<QuizContext>
    {
        protected override void Seed(QuizContext context)
        {
            var listLecturer = new List<Lecturer>{
                new Lecturer{FirstName = "Administrator",LastName = "Master",Email = "admin@admin.com",Password = "123",IsAdm = true,}
            };
            listLecturer.ForEach(lect => context.Lecturers.Add(lect));
            context.SaveChanges();
        }
    }
}