using Microsoft.EntityFrameworkCore;
using notes.Data;
using notes.Models;

namespace notes.Services
{
    public class NoteService : INoteService
    {
        List<Note> notes;
        private readonly NotesContext _context;

        public NoteService(NotesContext context)
        {
            _context = context;
        }

        public Task Add(Note note)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Note> Get(int id)
        {
            return await _context.Notes.FirstOrDefaultAsync(x =>  x.Id == id);
        }

        public async Task<IEnumerable<Note>> GetAll()
        {
            return await _context.Notes.OrderBy(x => x.DateOfEdition).ToListAsync();
        }

        public Task Update(Note note)
        {
            throw new NotImplementedException();
        }
    }
}
