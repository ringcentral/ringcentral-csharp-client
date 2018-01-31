namespace RingCentral
{
    public partial class DeviceOrderCreation
    {
        // List of devices ordered
        public DeviceResource[] @devices { get; set; }
        // For Async Order Only. Information on device ordering task
        public TaskInfo @task { get; set; }
    }
}
