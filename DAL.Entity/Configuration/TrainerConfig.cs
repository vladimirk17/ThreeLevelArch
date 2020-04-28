using System.Data.Entity.ModelConfiguration;
using DAL.Entity.Models;

namespace DAL.Entity.Configuration
{
    public class TrainerConfig : EntityTypeConfiguration<Trainer>
    {
        public TrainerConfig()
        {
            Property(_ => _.FirstName).IsRequired().HasMaxLength(20);
            Property(_ => _.LastName).IsRequired().HasMaxLength(20);
        }
    }
}