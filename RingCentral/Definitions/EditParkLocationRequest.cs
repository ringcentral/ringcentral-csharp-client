namespace RingCentral
{
    public partial class EditParkLocationRequest
    {
        // List of users that will be allowed to park/unpark calls using the specified park location
        public string[] @addedUserIds { get; set; }
        // List of users that will be unallowed to park/unpark calls using the specified park location
        public string[] @removedUserIds { get; set; }
    }
}
