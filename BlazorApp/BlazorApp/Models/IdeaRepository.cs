using BlazorApp.Data;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Models
{
    public class IdeaRepository : IIdeaRepository
    {

        private readonly ApplicationDbContext _context;

        public IdeaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Idea> AddIdea(Idea idea)
        {
            _context.Ideas.Add(idea);
            _context.SaveChanges(); //Db동기화

            return idea;
        }

        //Db에서 목록 조회 하여 return;
        public async Task<List<Idea>> GetIdeas()
        {
            return await _context.Ideas.ToListAsync();
        }
    }
}
