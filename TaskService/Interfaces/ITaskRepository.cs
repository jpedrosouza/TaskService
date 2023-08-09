using TaskService.Models;

namespace TaskService.Interfaces
{
    public interface ITaskRepository
    {
        Task<List<TaskModel>> ListAllTasks();
        Task<List<TaskModel>> ListAllTaksByType(String type);
        Task<List<TaskModel>> ListAllTasksByStatus(TaskStatus status);
        Task<TaskModel> CreateTask(TaskModel taskModel);
        Task<TaskModel>? GetById(int id);
    }
}
