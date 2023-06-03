using notes.Models;

namespace notes.Services
{
    public interface INoteService
    {
        Task<IEnumerable<Note>> GetAll();
        Task<Note> Get(int id);
        Task Add(Note note);
        Task Update(Note note);
        Task Delete(int id);

    }
}
