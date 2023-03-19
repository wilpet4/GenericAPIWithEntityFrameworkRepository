using API.Controllers.Base;
using API.Repository;
using Database.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class PersonController : ApiController<Person>
    {
        public PersonController(IRepository<Person> repository) : base(repository) { }
    }
}
