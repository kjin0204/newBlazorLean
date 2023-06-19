using BlazorApp.Data;
using BlazorApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Control
{
    public class TodoRepository : ITodoRepository
    {
        readonly ApplicationDbContext _context;

        //생성자
        public TodoRepository(ApplicationDbContext context)
        { 
            _context = context;
        }

        public async Task<Todo> DeleteTodo(Todo todo)
        {
            _context.Todos.Remove(todo);
            _context.SaveChanges();

            return todo;
        }

        //todo List Db에서 가져오기
        public async Task<List<Todo>> GetAllTodos()
        {
            return await _context.Todos.ToListAsync();
        }

        //todo List Db에 insert
        public async Task<Todo> SetTodo(Todo todo)
        {
            _context.Todos.Add(todo);
            _context.SaveChanges();

            return todo;
        }


    }
}
