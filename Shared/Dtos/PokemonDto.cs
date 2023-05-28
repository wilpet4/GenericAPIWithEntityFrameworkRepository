using Shared.Dtos.Base;
using System.ComponentModel.DataAnnotations;

namespace Shared.Dtos
{
    public class PokemonDto : DataTransferObject
    {
        [Required]
        public int Id { get; set; }

        [Required, MaxLength(255)]
        public string Name { get; set; }

        [Required]
        public List<PokemonTypeDto> Types { get; set; }
    }
}
