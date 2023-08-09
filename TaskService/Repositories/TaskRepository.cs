using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using TaskService.Data;
using TaskService.Interfaces;
using TaskService.Models;

namespace TaskService.Repositories
{
    public class TaskRepository: ITaskRepository
    {
        private readonly TaskServiceDbContext _taskServiceDbContext;

        public TaskRepository(TaskServiceDbContext taskServiceDbContext) { 
            _taskServiceDbContext = taskServiceDbContext;
        }

        public async Task<List<TaskModel>> ListAllTasks()
        {
            return await _taskServiceDbContext.Tasks.ToListAsync();
        }

        public async Task<List<TaskModel>> ListAllTaksByType(String type)
        {
            return await _taskServiceDbContext.Tasks.Where(e => e.Type == type).ToListAsync();
        }

        public async Task<List<TaskModel>> ListAllTasksByStatus(int status)
        {
            return await _taskServiceDbContext.Tasks.Where(e => e.Status == status).ToListAsync();
        }

        public async Task<TaskModel> CreateTask(TaskModel taskModel) 
        {
            _taskServiceDbContext.Tasks.Add(taskModel);
            await _taskServiceDbContext.SaveChangesAsync();

            return taskModel;
        }

        public Task<TaskModel?> GetById(int id) {
            return _taskServiceDbContext.Tasks.FirstOrDefaultAsync(_x => _x.Id == id);
        }
    }
}
