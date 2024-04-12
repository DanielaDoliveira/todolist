using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Communication.Enums;

namespace TodoList.Communication.Requests;

public class RequestTaskJson
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public PriorityEnum Priority { get; set; }
    public StatusEnum Status { get; set; }
}