using Database.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace Database.Entities
{
    public class Course : Entity
    {
        [Key][Required]
        public string Id { get; set; }
        public string Title { get; set; }

        public ICollection<Student> Students { get; set; }

        public Teacher Teacher { get; set; }
    }
}
