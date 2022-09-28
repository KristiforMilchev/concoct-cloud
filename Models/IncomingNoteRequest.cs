namespace Rokono_Control.Models
{
    public class IncomingNoteRequest
    {
        public int ProjectId { get; set; }
        public string Content { get; set; }
        public string Background { get; set; }
        public string FontColor { get; set; }
        public int NoteId { get; set; }
        public string Top { get; set; }
        public string Left { get; set; }
    }
}