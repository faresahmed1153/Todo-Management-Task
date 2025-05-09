using System;
using TodoManagement.Solution.Enums;
using Volo.Abp.Domain.Entities.Auditing;

namespace TodoManagement.Solution.Entities;
public class Todo : FullAuditedAggregateRoot<Guid>
{

    public string Title { get; set; }

    public string? Description { get; set; }

    public TodoStatus Status { get; set; }

    public TodoPriority Priority { get; set; }

    public DateTime? DueDate { get; set; }



}

