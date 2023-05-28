using AutoMapper;
using Database.Entities;
using Shared.Dtos;

namespace API.Mappings
{
    public class TrainerMap : Profile
    {
        public TrainerMap()
        {
            CreateMap<Trainer, TrainerDto>();
        }
    }
}
