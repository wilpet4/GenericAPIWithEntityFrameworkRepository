using Database.Entities.Base;

namespace Database.Entities
{
    public class PokemonType : Entity
    {
        public int Id { get; set; }
        public string Value { get; set; }

        public virtual List<Pokemon> Pokemon { get; set; }
    }
}
