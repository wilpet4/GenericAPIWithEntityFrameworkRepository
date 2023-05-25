using Database.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Entities
{
    public class Teacher : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string ClassroomNumber { get; set; }
        public Classroom Classroom { get; set; }

        [ForeignKey("TeacherId")]
        public ICollection<Course> Courses { get; set; }
    }
}
