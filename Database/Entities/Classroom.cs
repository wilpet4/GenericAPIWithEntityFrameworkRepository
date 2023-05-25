using Database.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace Database.Entities
{
    public class Classroom : Entity
    {
        [Key][Required]
        public string Number { get; set; }

        public Teacher Teacher { get; set; }
    }
}
