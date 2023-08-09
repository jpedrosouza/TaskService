namespace TaskService.Models
{
    public class TaskModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string Type { get; set; }
        public TaskStatus Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }

        public TaskModel(int id, string name, string? description, string type, TaskStatus status, DateTime createdDate, DateTime updatedDate, DateTime? deletedDate)
        {
            Id = id;
            Name = name;
            Description = description;
            Type = type;
            Status = status;
            CreatedDate = createdDate;
            UpdatedDate = updatedDate;
            DeletedDate = deletedDate;
        }

        public TaskModel() { }
    }
}
