
using Microsoft.AspNetCore.Mvc;
using TodoList.Application.UseCases.Task;
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
    //    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
    public IActionResult Register(RequestTaskJson request)
    {
        var useCase = new RegisterTaskUseCase();
        var response = useCase.Execute(request);
        return Created(string.Empty, response);
    }
    [HttpPut]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Update([FromRoute] int id, [FromBody] RequestTaskJson request)
    {
        var useCase = new UpdateTaskUseCase();
        useCase.Execute(id, request);
        return NoContent();
    }

}