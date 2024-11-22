using TaskManager.Communication.Enums;

namespace TaskManager.Communication.Requests;
public class RequestUpdateTaskJson
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public Priority TaskPriority { get; set; }
    public DateTime Deadline { get; set; }
    public Status TaskStatus { get; set; }
}
