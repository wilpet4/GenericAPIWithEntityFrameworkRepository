using Database.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace Database.Entities
{
    public class Student : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Required]
        public ICollection<Course> Courses { get; set; }
    }
}
