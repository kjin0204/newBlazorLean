using BlazorApp.Models;

namespace BlazorApp.Control
{
    public interface ITodoRepository
    {

        Task<Todo> SetTodo(Todo todo);
        Task<Todo> DeleteTodo(Todo todo);

        Task<List<Todo>> GetAllTodos();


    }
}
