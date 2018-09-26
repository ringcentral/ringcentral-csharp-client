namespace RingCentral
{
    public partial class GlipNoteCreate
    {
        // Title of a note
        public string @title { get; set; }
        // If a note should be immediately published then pass 'Active' value. This doesn't create a new post in the current group but as a result the note can be read by members of this group
        public string @status { get; set; }
        // Contents of a note, which is HTML-markuped multiline text
        public string @body { get; set; }
    }
}
