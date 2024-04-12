
using TodoList.Communication.Enums;
namespace TodoList.Communication.Responses;

public class ResponseTaskJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; }
    public PriorityEnum Priority { get; set; }
    public StatusEnum Status { get; set; }
}