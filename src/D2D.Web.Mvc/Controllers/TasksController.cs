
using System.Threading.Tasks;
using D2D.Controllers;
using D2D.Tasks;
using D2D.Tasks.Dtos;
using Microsoft.AspNetCore.Mvc;
using D2D.Web.Models.Tasks;


namespace D2D.Web.Controllers
{
    public class TasksController : D2DControllerBase
    {
        private readonly ITaskAppService _taskAppService;

        public TasksController(ITaskAppService taskAppService)
        {
            _taskAppService = taskAppService;
        }

        public async Task<ActionResult> Index(GetAllTasksInput input)
        {
            var output = await _taskAppService.GetAll(input);
            var model = new IndexViewModel(output.Items)
            {
                SelectedTaskState = input.State
            };
            return View(model);
        }
    }
}
