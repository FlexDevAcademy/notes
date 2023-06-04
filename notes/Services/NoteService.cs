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

        public async Task Add(Note note)
        {
            _context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Notes ON");

            await _context.Notes.AddAsync(note);
            //note.Id = _context.Notes.Max(r => r.Id) + 1;
            await _context.SaveChangesAsync();

            _context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Notes OFF");
        }

        public async Task Delete(int id)
        {
            var note = await Get(id);
            if (note != null)
            {
                _context.Notes.Remove(note);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Note> Get(int id)
        {
            return await _context.Notes.FirstOrDefaultAsync(x =>  x.Id == id);
        }

        public async Task<IEnumerable<Note>> GetAll()
        {
            return await _context.Notes.OrderBy(x => x.DateOfEdition).ToListAsync();
        }

        public async Task Update(Note note)
        {
            var existingNote = await Get(note.Id);

            if (existingNote != null)
            {
                existingNote.Title = note.Title;
                existingNote.Description = note.Description;
                existingNote.DateOfEdition = DateTime.Now;
                await _context.SaveChangesAsync();
            }
        }
    }
}
