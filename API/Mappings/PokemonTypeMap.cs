using AutoMapper;
using Database.Entities;
using Shared.Dtos;

namespace API.Mappings
{
    public class PokemonTypeMap : Profile
    {
        public PokemonTypeMap() 
        {
            CreateMap<PokemonType, PokemonTypeDto>();
        }
    }
}
