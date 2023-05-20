using API.Controllers.Base;
using API.Repository;
using Database.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassroomController : ApiController<Classroom>
    {
        public ClassroomController(IRepository<Classroom> repository) : base(repository) { }
    }
}
