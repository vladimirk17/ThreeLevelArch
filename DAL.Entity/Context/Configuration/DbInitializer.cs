using System.Data.Entity;
using DAL.Entity.Models;

namespace DAL.Entity.Context.Configuration
{
    public class DbInitializer : DropCreateDatabaseAlways<ThreeTierContext>
    {
        protected override void Seed(ThreeTierContext context)
        {
            var student1 = new Student
            {
                Name = "Ivan",
                LastName = "Petrov",
                Phone = "+3802225551",
                City = "Kyiv"
            };

            context.Students.Add(student1);
            context.SaveChanges();
        }
    }
}