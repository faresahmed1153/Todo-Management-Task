using Microsoft.AspNetCore.Mvc;
using Serilog;
using System;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using TodoManagement.Solution.Contracts;
using TodoManagement.Solution.Dtos;
using TodoManagement.Solution.Entities;
using TodoManagement.Solution.Enums;
using Volo.Abp;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories;

namespace TodoManagement.Solution.Services;


public class TodoAppService : CrudAppService<
            Todo,
        TodoDto,
        Guid,
        TodoGetListFilter,
        CreateUpdateTodoDto
        >, ITodoAppService
{


    public TodoAppService(IRepository<Todo, Guid> repository) : base(repository)
    {


    }


    [HttpPut]
    public async Task DoneAsync(Guid id)
    {
        try
        {
            var todo = await Repository.GetAsync(id);

            if (todo == null)
            {
                throw new EntityNotFoundException(typeof(Todo), id);
            }


            if (todo.Status == TodoStatus.Completed)
            {
                throw new UserFriendlyException("This todo is already completed!");
            }

            todo.Status = TodoStatus.Completed;

            await Repository.UpdateAsync(todo);

        }
        catch (Exception ex)
        {
            Log.Error(ex, "Error occurred while marking todo as done");

        }

    }

    protected override async Task<IQueryable<Todo>> CreateFilteredQueryAsync(TodoGetListFilter input)
    {

        var query = await base.CreateFilteredQueryAsync(input);


        if (input is TodoGetListFilter todoInput && todoInput.Status.HasValue)
        {
            query = query.Where(t => t.Status == todoInput.Status.Value);
        }

        return query;


    }

    protected override IQueryable<Todo> ApplySorting(IQueryable<Todo> query, TodoGetListFilter input)
    {

        query = query.OrderByDescending(t => t.CreationTime);


        if (!input.Sorting.IsNullOrWhiteSpace())
        {
            query = query.OrderBy(input.Sorting);
        }

        return query;
    }
}
