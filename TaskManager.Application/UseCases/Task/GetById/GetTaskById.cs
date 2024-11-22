using System.Xml.Linq;
using TaskManager.Communication.Enums;
using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCases.Task.GetById;
public class GetTaskById
{
    public ResponseShortTaskJson Execute(int id)
    {
        return new ResponseShortTaskJson()
        {
            Id = id,
            Name = "Task 1",
            Description = "Descrição da task 1",
            Deadline = new DateTime(year: 2024, month: 11, day: 22),
            TaskStatus = Status.EmAndamento,
            TaskPriority = Priority.Baixa
        };
    }
}
