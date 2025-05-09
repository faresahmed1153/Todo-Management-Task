using TodoManagement.Solution.Enums;
using Volo.Abp.Application.Dtos;

namespace TodoManagement.Solution.Dtos;
public class TodoGetListFilter : PagedAndSortedResultRequestDto
{
    public TodoStatus? Status { get; set; }

}

