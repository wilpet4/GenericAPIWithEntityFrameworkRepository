using AutoMapper;
using Database.Entities;
using Shared.Dtos;

namespace API.Mappings
{
    public class PokemonMap : Profile
    {
        public PokemonMap()
        {
            CreateMap<Pokemon, PokemonDto>();
        }
    }
}
