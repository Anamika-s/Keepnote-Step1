using Keepnote_Step1.Models;

namespace Keepnote_Step1.IRepo
{
    public interface INoteRepository
    {
        List<Note> GetNotes();
        int AddNote(Note note);
        int Delete(int id);
        Note GetNoteById(int id);
        int EditNote(int id, Note note);
    }
}
