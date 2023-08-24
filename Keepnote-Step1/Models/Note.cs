namespace Keepnote_Step1.Models
{
    public class Note
    {
        public int NoteId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public string AuthorName { get; set; }
        public string UpdatedDate { get; set; }


    }
}
