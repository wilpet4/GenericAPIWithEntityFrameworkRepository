using Database.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace Database.Entities
{
    public class Item : Entity
    {
        public int Id { get; set; }

        [Required, MaxLength(255)]
        public string Name { get; set; }

        public int Price { get; set; }
    }
}
