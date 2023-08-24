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

        // ModelBuilder class acts as a fluentapi
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Batch>().
                ToTable("tblBatch");

            modelBuilder.Entity<Batch>()
                 .Property(s => s.StartDate)
                .HasColumnName("BatchStartDate")
                .HasDefaultValue(DateTime.Now)
                .IsRequired();


        }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Batch> Batches { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
    }
}
