using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using TodoManagement.Solution.Dtos;
using Volo.Abp.Application.Services;

namespace TodoManagement.Solution.Contracts;

public interface ITodoAppService :
    ICrudAppService<
        TodoDto,
        Guid,
        TodoGetListFilter,
        CreateUpdateTodoDto>
{
    [HttpPut]
    Task DoneAsync(Guid id);


}