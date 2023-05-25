using API.Controllers.Base;
using API.Repository;
using Database.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ClassroomController : ApiController<Classroom, string>
    {
        public ClassroomController(IRepository<Classroom, string> repository) : base(repository) { }
    }
}
