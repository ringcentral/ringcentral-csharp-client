namespace RingCentral
{
    public partial class GlipNoteInfo
    {
        // Internal identifier of a note
        public string @id { get; set; }
        // Title of a note
        public string @title { get; set; }
        // Preview of a note (first 150 characters of a body)
        public string @preview { get; set; }
        // Internal identifier of a note creator
        public string @creatorId { get; set; }
        // A note is locked by another user. If the lock was placed more than 5 hours ago, then a note should be unlocked
        public object @lockedBy { get; set; }
        // Status of a note. Any note is created in 'Draft' status. After it is posted it becomes 'Active'
        public string @status { get; set; }
        // Creation time
        public string @creationTime { get; set; }
        // Datetime of the note last update
        public string @lastModifiedTime { get; set; }
    }
}
