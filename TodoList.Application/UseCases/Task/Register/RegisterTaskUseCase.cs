

using TodoList.Communication.Requests;
namespace TodoList.Communication.Responses;

public class RegisterTaskUseCase
{
    public ResponseTaskJson Execute(RequestTaskJson request)
    {
        return new ResponseTaskJson
        {
            Id = 2,
            Name = request.Name,
            Description = request.Description,
            Priority = request.Priority,
            LimitDate = request.LimitDate,
            Status = request.Status,

        };
    }
}