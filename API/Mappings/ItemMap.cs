using AutoMapper;
using Database.Entities;
using Shared.Dtos;

namespace API.Mappings
{
    public class ItemMap : Profile
    {
        public ItemMap()
        {
            CreateMap<Item, ItemDto>();
        }
    }
}
