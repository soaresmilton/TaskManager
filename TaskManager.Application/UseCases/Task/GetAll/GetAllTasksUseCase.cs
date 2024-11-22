using TaskManager.Communication.Enums;
using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCases.Task.GetAll;
public class GetAllTasksUseCase
{
    public ResponseAllTaskJson Execute()
    {
        return new ResponseAllTaskJson()
        {
            Tasks =
            {
                new ResponseShortTaskJson()
                {
                    Id = 1,
                    Name = "Task 1",
                    Description = "Descrição da task 1",
                    Deadline = new DateTime(year: 2024, month: 11, day: 22),
                    TaskStatus = Status.EmAndamento,
                    TaskPriority = Priority.Baixa
                },
                 new ResponseShortTaskJson()
                {
                    Id = 2,
                    Name = "Task 2",
                    Description = "Descrição da task 2",
                    Deadline = new DateTime(year: 2024, month: 11, day: 22),
                    TaskStatus = Status.Concluída,
                    TaskPriority = Priority.Alta
                }
            }
        };
    }
}
