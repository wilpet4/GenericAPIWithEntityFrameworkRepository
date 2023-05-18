using API.Repository;
using Database.Entities.Base;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Base
{
    [ApiController]
    public abstract class ApiController<T> : ControllerBase where T : Entity
    {

        protected readonly IRepository<T> _repository;

        public ApiController(IRepository<T> repository)
        {
            _repository = repository;
        }

        [HttpGet("{id}")]
        public virtual async Task<ActionResult<T>> GetEntity(int id)
        {
            try
            {
                var entity = await _repository.GetEntity(id);

                if (entity == null) { return NotFound(); }

                return Ok(entity);
            }
            catch (Exception e)
            {
                return StatusCode(500);
            }
        }

        [HttpGet]
        public virtual async Task<ActionResult<IEnumerable<T>>> GetAllEntities()
        {
            try
            {
                var entities = await _repository.GetAllEntities();

                if (entities == null) { return NotFound(); }

                return Ok(entities);
            }
            catch (Exception e)
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        public virtual async Task<IActionResult> CreateEntity(T entity)
        {
            try
            {
                if (entity == null) { return NotFound(); }

                await _repository.CreateEntity(entity);

                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500);
            }
        }

        [HttpPut("{id}")]
        public virtual async Task<IActionResult> UpdateEntity(int id, T entity)
        {
            try
            {
                if (entity == null) { return NotFound(); }

                await _repository.UpdateEntity(entity);

                return NoContent();
            }
            catch (Exception e)
            {
                return StatusCode(500);
            }
        }

        [HttpDelete("{id}")]
        public virtual async Task<IActionResult> DeleteEntity(int id)
        {
            try
            {
                var entity = await _repository.GetEntity(id);

                if (entity == null) { return NotFound(); }

                await _repository.DeleteEntity(id);

                return NoContent();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
    }
}
