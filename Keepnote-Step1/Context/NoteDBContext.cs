using Keepnote_Step1.Models;
using Microsoft.EntityFrameworkCore;

namespace Keepnote_Step1.Context
{
    public class NoteDBContext : DbContext
    {
        public NoteDBContext(DbContextOptions<NoteDBContext> context)
            : base (context)
        {

        }
        public DbSet<Note> Notes { get; set; }
    }
}
