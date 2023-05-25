using API.Controllers.Base;
using API.Repository;
using Database.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class StudentController : ApiController<Student, int>
    {
        public StudentController(IRepository<Student, int> repository) : base(repository) { }
    }
}
