using Microsoft.EntityFrameworkCore;
using notes.Models;
namespace notes.Data
{
    public class DbInitializer
    {
        public static void Initialize(NotesContext context)
        {
            context.Database.EnsureCreated();

            if (context.Notes.Any())
            {
                return;
            }

            var notes = new Note[]
            {
                new Note { Title = "title1", Description= "Forni Rossi", Created=DateTime.Now, DateOfEdition=DateTime.Now}
                
            };
            context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Notes ON");
            foreach (var x in notes)
            {
                context.Notes.Add(x);

            }

            context.SaveChanges();
            context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Notes OFF");


        }
    }
}
