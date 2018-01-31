namespace RingCentral
{
    public partial class EditGroupRequest
    {
        // List of users to be added to the team
        public string[] @addedPersonIds { get; set; }
        // List of user email addresses to be added to the team (i.e. as guests)
        public string[] @addedPersonEmails { get; set; }
        // List of users to be removed from the team
        public string[] @removedPersonIds { get; set; }
    }
}
