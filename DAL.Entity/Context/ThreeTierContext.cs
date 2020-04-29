using System.Data.Entity;
using DAL.Entity.Context.Configuration;
using DAL.Entity.Models;

namespace DAL.Entity.Context
{
    public class ThreeTierContext : DbContext
    {
        static ThreeTierContext() =>
            Database.SetInitializer(new DbInitializer());

        public ThreeTierContext()
            : base("name=ThreeTierContext")
        {
        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Speciality> Specialities { get; set; }
        public virtual DbSet<Trainer> Trainers { get; set; }
        public virtual DbSet<Group> Groups { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsToModels();
            
            base.OnModelCreating(modelBuilder);
        }
    }
}