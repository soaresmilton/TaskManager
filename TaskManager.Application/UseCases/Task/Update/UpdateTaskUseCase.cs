using TaskManager.Communication.Requests;

namespace TaskManager.Application.UseCases.Task.Update;
public class UpdateTaskUseCase
{
    public void Execute(int id, RequestUpdateTaskJson request)
    {
        // Logica do Update
        // No caso vai fazer um lookup na tabela de pets, pegando o registro quando o ID for igual ao id
        // Faz a atualização das informacoes com base nos dados passados no request.
        // os dados do request vem num formulário
    }
}
