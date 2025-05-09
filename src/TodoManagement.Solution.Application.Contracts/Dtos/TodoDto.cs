using System;
using TodoManagement.Solution.Enums;
using Volo.Abp.Application.Dtos;

namespace TodoManagement.Solution.Dtos;
public class TodoDto : FullAuditedEntityDto<Guid>
{
    public string Title { get; set; }
    public string Description { get; set; }
    public TodoStatus Status { get; set; }
    public TodoPriority Priority { get; set; }
    public DateTime? DueDate { get; set; }

}
