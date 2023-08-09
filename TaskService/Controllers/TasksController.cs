using Microsoft.AspNetCore.Mvc;
using TaskService.Interfaces;
using TaskService.Models;
using TaskService.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TaskService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly ITaskRepository _taskRepository;


        public TasksController(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        // GET: api/<TasksController>
        [HttpGet]
        public async Task<ActionResult<List<TaskModel>>> Get()
        {
            List<TaskModel> tasks = await _taskRepository.ListAllTasks();
            return Ok(tasks);
        }

        // GET api/<TasksController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TaskModel>> Get(int id)
        {
            return await _taskRepository.GetById(id);
        }                                    

        // POST api/<TasksController>
        [HttpPost]
        public async Task<ActionResult<TaskModel>> Post([FromBody] TaskModel task)
        {
            await _taskRepository.CreateTask(task);
            return Ok(task);
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
