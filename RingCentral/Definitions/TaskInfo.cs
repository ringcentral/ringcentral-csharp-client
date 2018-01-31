namespace RingCentral
{
    public partial class TaskInfo
    {
        // Internal identifier of a task
        public string @id { get; set; }
        // Link to a task resource
        public string @uri { get; set; }
        // Device order status
        public string @status { get; set; }
        // Task creation time
        public string @creationTime { get; set; }
        // Time of task last modification
        public string @lastModifiedTime { get; set; }
    }
}
