using API.Controllers.Base;
using API.Repository;
using Database.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class StudentController : ApiController<Student>
    {
        public StudentController(IRepository<Student> repository) : base(repository) { }
    }
}
