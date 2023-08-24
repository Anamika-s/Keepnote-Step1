
namespace Keepnote_Step1.Models
{
    public class Batch
    {
        public int BatchId { get; set; }
        public string BatchName { get; set; }
        public DateTime StartDate { get; set; }
        //public string Trainer { get; set; }
        // Add fKey
        public Course Course { get; set; }

        public Trainer Trainer { get; set; }
    }
}
