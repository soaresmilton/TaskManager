using TaskManager.Communication.Enums;

namespace TaskManager.Communication.Responses;
public class ResponseShortTaskJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public Status TaskStatus { get; set; }
    public Priority TaskPriority { get; set; }
    public DateTime Deadline { get; set; }
}
