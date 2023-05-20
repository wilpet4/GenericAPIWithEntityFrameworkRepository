using Database.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace Database.Entities
{
    public class Classroom : Entity
    {
        public int Id { get; set; }
        public string Number { get; set; }

        [Required]
        public Teacher Teacher { get; set; }
    }
}
