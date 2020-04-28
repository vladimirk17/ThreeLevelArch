using System.Data.Entity.ModelConfiguration;
using DAL.Entity.Models;

namespace DAL.Entity.Configuration
{
    public class StudentConfig : EntityTypeConfiguration<Student>
    {
        public StudentConfig()
        {
            Property(_ => _.Name).IsRequired().HasMaxLength(20);
            Property(_ => _.LastName).IsRequired().HasMaxLength(20);
            Property(_ => _.SpecialityId).IsRequired();
        }
    }
}