using Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Database.Context
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Teacher> Teacher { get; set; }

        public DatabaseContext() { }
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
            .AddJsonFile($"appsettings.json", true, true);

            string connectionString =
            builder.Build().GetConnectionString("DefaultConnection");

            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
        public static void CreateData(DatabaseContext context)
        {
            Classroom r1 = new Classroom { Number = "R101" };
            Classroom r2 = new Classroom { Number = "R202" };

            Teacher t1 = new Teacher { Name = "Anna Anderson", Classroom = r1 };
            Teacher t2 = new Teacher { Name = "Bianca Bingham", Classroom = r2 };

            Course c1 = new Course { Id = "EF1", Title = "Introduction to EF Core", Teacher = t1};
            Course c2 = new Course { Id = "CM1", Title = "Basic Car Maintenance", Teacher = t2};

            Student s1 = new Student { Name = "Jenny Jones"};
            Student s2 = new Student { Name = "Kenny Kent" };
            Student s3 = new Student { Name = "Lucy Locket" };
            Student s4 = new Student { Name = "Micky Most" };
            Student s5 = new Student { Name = "Nelly Norton" };
            Student s6 = new Student { Name = "Ozzy Osborne" };


            c1.Students = new Student[] { s1, s2, s3, s4 };
            c2.Students = new Student[] { s3, s4, s5, s6 };

            context.Add(c1);
            context.Add(c2);

            context.SaveChanges();
        }
    }
}
