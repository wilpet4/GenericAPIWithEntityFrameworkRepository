using Database.Entities.Base;

namespace Database.Entities
{
    public class Course : Entity
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public ICollection<Student> Students { get; set; }

        public Teacher Teacher { get; set; }
    }
}
