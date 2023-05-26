using Database.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace Database.Entities
{
    public class Pokemon : Entity
    {
        [Key, Required]
        public int Id { get; set; }

        [Required, MaxLength(255)]
        public string Name { get; set; }

        [Required]
        public List<PokemonType> Types { get; set; }
    }
}
