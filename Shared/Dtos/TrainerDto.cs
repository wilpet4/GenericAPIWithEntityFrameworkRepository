using Shared.Dtos.Base;
using System.ComponentModel.DataAnnotations;

namespace Shared.Dtos
{

    public class TrainerDto : DataTransferObject
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(255)]
        public string Name { get; set; }

        [Required]
        public List<PokemonDto> Pokemon { get; set; }
    }
}
