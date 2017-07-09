using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using D2D.Tasks.Dtos;

namespace D2D.Tasks
{
    public interface ITaskAppService : IApplicationService
    {
        Task<ListResultDto<TaskListDto>> GetAll(GetAllTasksInput input);

        System.Threading.Tasks.Task Create(CreateTaskInput input);
    }
}