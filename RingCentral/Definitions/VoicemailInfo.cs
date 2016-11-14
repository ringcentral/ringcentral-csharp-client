namespace RingCentral
{
    public partial class VoicemailInfo
    {
        // If 'True' then voicemails are allowed to be received
        public bool? @enabled { get; set; }
        // Recipient data
        public RecipientInfo @recipient { get; set; }
    }
}
