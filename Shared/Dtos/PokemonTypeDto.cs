using Shared.Dtos.Base;

namespace Shared.Dtos
{
    public class PokemonTypeDto : DataTransferObject
    {
        public int Id { get; set; }
        public string Value { get; set; }
    }
}
