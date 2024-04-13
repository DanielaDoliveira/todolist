
using TodoList.Communication.Responses;

namespace TodoList.Application.UseCases.Task.GetById;

public class GetTaskByIdUseCase
{
    public ResponseTaskJson Execute(int id)
    {
        return new ResponseTaskJson
        {
            Id = id,
            Name = " .NET",
            Description = "Revisar os métodos Get,Post,Put e Delete",
            Priority = Communication.Enums.PriorityEnum.Important,
            LimitDate = new DateTime(year: 2023, month: 1, day: 2),
            Status = Communication.Enums.StatusEnum.Doing,

        };
    }
}