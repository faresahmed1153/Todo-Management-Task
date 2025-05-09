using System;
using System.ComponentModel.DataAnnotations;
using TodoManagement.Solution.Enums;
using TodoManagement.Solution.Validations;
namespace TodoManagement.Solution.Dtos;

public class CreateUpdateTodoDto
{

    [Required]
    [StringLength(100)]
    public string Title { get; set; }

    [StringLength(500)]
    public string? Description { get; set; }


    public TodoPriority Priority { get; set; }

    public TodoStatus Status { get; set; }

    [DataType(DataType.DateTime)]
    [FutureDateValidation(ErrorMessage = "Due date must be in the future!")]
    public DateTime? DueDate { get; set; }


}
