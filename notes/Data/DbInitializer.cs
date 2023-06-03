using Microsoft.EntityFrameworkCore;
using notes.Models;
namespace notes.Data
{
    public class DbInitializer
    {
        public static async Task Initialize(NotesContext context)
        {

            context.Database.EnsureCreated();
            if (context.Notes.Any())
            {
                return;
            }


        }
    }
}
