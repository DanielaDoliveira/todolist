

using TodoList.Communication.Responses;

namespace TodoList.Application.UseCases.Task.GetAll;

public class GetAllTasksUseCase
{
    public ResponseAllTasksJson Execute()
    {
        return new ResponseAllTasksJson
        {
            Tasks = new List<ResponseShortTaskJson>
            {
               new ResponseShortTaskJson{
            Id = 1,
            Name = " .NET",
            Description = "Revisar os métodos Get,Post,Put e Delete",
            Priority = Communication.Enums.PriorityEnum.Important,
            LimitDate = new DateTime(year: 2023, month: 1, day: 2),
            Status = Communication.Enums.StatusEnum.Doing,
               },
               new ResponseShortTaskJson{
            Id = 2,
            Name = " Vs Code",
            Description = "Como usar o .NET com o VS Code",
            Priority = Communication.Enums.PriorityEnum.NotImportantForNow,
            LimitDate = new DateTime(year: 2023, month: 12, day: 10),
            Status = Communication.Enums.StatusEnum.Finished,
               }
            }
        };
    }
}