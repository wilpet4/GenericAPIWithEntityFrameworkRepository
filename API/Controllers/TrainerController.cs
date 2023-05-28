using API.Controllers.Base;
using API.Repository;
using Database.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.Dtos;

namespace API.Controllers
{
    public class TrainerController : ApiController<Trainer, int>
    {
        public TrainerController(IRepository<Trainer, int> repository) : base(repository) { }
    }
}
