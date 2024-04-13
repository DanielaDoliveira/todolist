using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoList.Communication.Responses;

public class ResponseAllTasksJson
{
    public List<ResponseShortTaskJson> Tasks { get; set; } = [];
}