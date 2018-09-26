namespace RingCentral
{
    public partial class EditGroupRequest
    {
        // List of users to be added to a team
        public string[] @addedPersonIds { get; set; }
        // List of user email addresses to be added to a team (i.e. as guests)
        public string[] @addedPersonEmails { get; set; }
        // List of users to be removed from a team
        public string[] @removedPersonIds { get; set; }
    }
}
