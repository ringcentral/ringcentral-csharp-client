namespace RingCentral
{
    public partial class CfaSchedule
    {
        //
        public string @scheduleId { get; set; }
        //
        public CfaRecurrence @recurrence { get; set; }
        //
        public string @viewType { get; set; }
        //
        public CfaAttachments @attachments { get; set; }
        //
        public string[] @recipients { get; set; }
        //
        public string[] @pages { get; set; }
    }
}
