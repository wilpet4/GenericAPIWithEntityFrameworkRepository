using Database.Entities.Base;

namespace Database.Entities
{
    public class Person : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
