
using Microsoft.AspNetCore.Mvc;
using TodoList.Application.UseCases.Task;
using TodoList.Application.UseCases.Task.Delete;
using TodoList.Application.UseCases.Task.GetAll;
using TodoList.Application.UseCases.Task.GetById;
using TodoList.Application.UseCases.Task.Update;
using TodoList.Communication.Requests;
using TodoList.Communication.Responses;

namespace TodoList.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class TaskController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseTaskJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
    public IActionResult Register(RequestTaskJson request)
    {
        var useCase = new RegisterTaskUseCase();
        var response = useCase.Execute(request);
        return Created(string.Empty, response);
    }
    [HttpPut]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
    public IActionResult Update([FromRoute] int id, [FromBody] RequestTaskJson request)
    {
        var useCase = new UpdateTaskUseCase();
        useCase.Execute(id, request);
        return NoContent();
    }
    [HttpGet]
    [Route("{task_id}")]
    [ProducesResponseType(typeof(ResponseTaskJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status404NotFound)]
    public IActionResult GetById([FromRoute] int task_id)
    {
        var useCase = new GetTaskByIdUseCase();
        var response = useCase.Execute(task_id);
        return Ok(response);
    }


    [HttpGet]
    [ProducesResponseType(typeof(List<ResponseShortTaskJson>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
    public IActionResult GetAll()
    {
        var useCase = new GetAllTasksUseCase();
        var response = useCase.Execute();
        if (response.Tasks.Any())
            return Ok(response);
        else
            return NoContent();
    }

    [HttpDelete]
    [Route("{task_id}")]
    [ProducesResponseType(typeof(ResponseTaskJson), StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status404NotFound)]

    public IActionResult Delete(int task_id)
    {
        var useCase = new DeleteTaskByIdUseCase();
        useCase.Execute(task_id);
        return NoContent();
    }


}