using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskService.Models;

namespace TaskService.Data.Map
{
    public class TaskMap: IEntityTypeConfiguration<TaskModel>
    {
        public void Configure(EntityTypeBuilder<TaskModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Description).HasMaxLength(400);
            builder.Property(x => x.Type).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Status).IsRequired().HasMaxLength(200);
            builder.Property(x => x.CreatedDate).IsRequired().HasMaxLength(20);
            builder.Property(x => x.UpdatedDate).IsRequired().HasMaxLength(20);
            builder.Property(x => x.DeletedDate).IsRequired().HasMaxLength(20);
        }
    }
}
