using Microsoft.AspNetCore.Mvc;
using TaskService.Models;
using TaskService.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TaskService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        // GET: api/<TasksController>
        [HttpGet]
        public IEnumerable<TaskModel> Get()
        {
            return new TaskRepository().ListAllTasks();
        }

        // GET api/<TasksController>/5
        [HttpGet("{id}")]
        public TaskModel Get(int id)
        {
            return new TaskRepository().GetById(id);
        }

        // POST api/<TasksController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TasksController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TasksController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
