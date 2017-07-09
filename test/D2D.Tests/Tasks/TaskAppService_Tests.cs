using D2D.Tasks;
using D2D.Tasks.Dtos;
using Shouldly;
using Xunit;
using System.Linq;
using Abp.Runtime.Validation;
using D2D.Tests;

public class TaskAppService_Tests : D2DTestBase
{
    private readonly ITaskAppService _taskAppService;

    public TaskAppService_Tests()
    {
        _taskAppService = Resolve<ITaskAppService>();
    }

    [Fact]
    public async System.Threading.Tasks.Task Should_Get_All_Tasks()
    {
        //Act
         var output = await _taskAppService.GetAll(new GetAllTasksInput());

        //Assert
        output.Items.Count.ShouldBe(2);
    }

    [Fact]
    public async System.Threading.Tasks.Task Should_Get_Filtered_Tasks()
    {
        //Act
        var output = await _taskAppService.GetAll(new GetAllTasksInput { State = TaskState.Open });

        //Assert
        output.Items.ShouldAllBe(t => t.State == TaskState.Open);
    }
}