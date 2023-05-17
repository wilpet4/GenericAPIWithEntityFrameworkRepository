using Database.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Entities
{
    public class Teacher : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int? ClassroomId { get; set; }

        public Classroom Classroom { get; set; }

        [ForeignKey("AuthorId")]
        public ICollection<Course> CoursesWritten { get; set; }

        [ForeignKey("EditorId")]
        public ICollection<Course> CoursesEditted { get; set; }
    }
}
