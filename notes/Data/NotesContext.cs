using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;
using Microsoft.EntityFrameworkCore;
using notes.Models;

namespace notes.Data
{
    public class NotesContext : DbContext
    {
        public NotesContext(DbContextOptions<NotesContext> options) : base(options)
        { 

        }

        public DbSet<Note>Notes { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Note>(entity =>
            {
                entity.HasKey(n => n.Id);
                entity.Property(n => n.Id).HasColumnName("Id").HasComment("PrimaryKey");
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
