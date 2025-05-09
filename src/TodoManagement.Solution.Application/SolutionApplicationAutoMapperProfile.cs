using AutoMapper;
using TodoManagement.Solution.Dtos;
using TodoManagement.Solution.Entities;

namespace TodoManagement.Solution;

public class SolutionApplicationAutoMapperProfile : Profile
{
    public SolutionApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        CreateMap<Todo, TodoDto>();

        CreateMap<CreateUpdateTodoDto, Todo>();
    }
}
