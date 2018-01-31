namespace RingCentral
{
    public partial class EditPagingGroupRequest
    {
        // List of users that will be allowed to page a group specified
        public string[] @addedUserIds { get; set; }
        // List of users that will be unallowed to page a group specified
        public string[] @removedUserIds { get; set; }
        // List of account devices that will be assigned to a paging group specified
        public string[] @addedDeviceIds { get; set; }
        // List of account devices that will be unassigned from a paging group specified
        public string[] @removedDeviceIds { get; set; }
    }
}
